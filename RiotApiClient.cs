using System.Net;
using System.Text.Json;
using Polly;
using Seiori.RiotAPI.Classes;
using Seiori.RiotAPI.Classes.League_Exp_V4;
using Seiori.RiotAPI.Classes.Match_V5;
using Seiori.RiotAPI.Enums;

namespace Seiori.RiotAPI;

public sealed class RiotApiClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonSerializerOptions;
    private readonly AsyncPolicy<HttpResponseMessage> _retryPolicy;
    private static readonly TimeSpan DefaultRetryDelay = TimeSpan.FromSeconds(1);
    private const string BaseUrl = "https://{0}.api.riotgames.com/";

    public RiotApiClient(RiotApiOptions options)
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("X-Riot-Token", options.Apikey);
        _jsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        var handle429OrNetwork = Policy
            .Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(r => r.StatusCode == (HttpStatusCode)429);

        Func<int, DelegateResult<HttpResponseMessage>, Context, TimeSpan> sleepDurationProvider = (retryAttempt, outcome, _) =>
        {
            TimeSpan baseInitialDelayForFallback = TimeSpan.FromSeconds(Math.Pow(options.ExponentialBackoffBase, 0));
            TimeSpan actualFallback429Delay = baseInitialDelayForFallback < options.MinRetryDelay ? options.MinRetryDelay : baseInitialDelayForFallback;

            if (outcome.Result?.StatusCode != (HttpStatusCode)429)
            {
                TimeSpan non429BaseDelay = TimeSpan.FromSeconds(Math.Pow(options.ExponentialBackoffBase, retryAttempt - 1));
                return non429BaseDelay < options.MinRetryDelay ? options.MinRetryDelay : non429BaseDelay;
            }
            
            var retryAfterHeader = outcome.Result.Headers.RetryAfter;
            if (retryAfterHeader == null) 
            {
                return actualFallback429Delay;
            }
            
            TimeSpan delayFromHeader;
            if (retryAfterHeader.Delta.HasValue)
            {
                delayFromHeader = retryAfterHeader.Delta.Value;
            }
            else if (retryAfterHeader.Date.HasValue)
            {
                delayFromHeader = retryAfterHeader.Date.Value - DateTimeOffset.UtcNow;
            }
            else
            {
                return actualFallback429Delay;
            }

            return delayFromHeader < options.MinRetryDelay ? options.MinRetryDelay : delayFromHeader;
        };

        _retryPolicy = options.RetryCount <= 0
            ? handle429OrNetwork.WaitAndRetryForeverAsync(
                sleepDurationProvider: sleepDurationProvider,
                onRetryAsync: async (outcome, timespan, _) =>
                {
                    if (options.Debug)
                    {
                        var reason = outcome.Exception?.Message ?? outcome.Result.StatusCode.ToString();
                        Console.Error.WriteLine($"[RiotApiClient] Retry forever after {timespan} due to {reason}");
                    }
                    await Task.CompletedTask;
                }
            )
            : handle429OrNetwork.WaitAndRetryAsync(
                options.RetryCount,
                sleepDurationProvider: sleepDurationProvider,
                onRetryAsync: async (outcome, timespan, attempt, _) =>
                {
                    if (options.Debug)
                    {
                        var reason = outcome.Exception?.Message ?? outcome.Result.StatusCode.ToString();
                        Console.Error.WriteLine($"[RiotApiClient] Retry {attempt}/{options.RetryCount} after {timespan} due to {reason}");
                    }
                    await Task.CompletedTask;
                }
            );
    }

    private async Task<T?> SendGetAsync<T>(string route, string path) where T : class
    {
        var baseUrl = string.Format(BaseUrl, route);
        var url = $"{baseUrl}{path}";

        try
        {
            var response = await _retryPolicy.ExecuteAsync(() => _httpClient.GetAsync(url));
            response.EnsureSuccessStatusCode();
        
            await using var stream = await response.Content.ReadAsStreamAsync();
            var result = await JsonSerializer.DeserializeAsync<T>(stream, _jsonSerializerOptions);
            if (result is null) throw new JsonException($"[RiotApiClient] Failed to deserialize response from {url}");
        
            return result;
        }
        catch (HttpRequestException e)
        {
            await Console.Error.WriteLineAsync($"[RiotApiClient] HTTP request error for {url}: {e.Message}");
        }
        catch (JsonException e)
        {
            await Console.Error.WriteLineAsync($"[RiotApiClient] JSON deserialization error for {url}: {e.Message}");
        }
        catch (Exception e)
        {
            await Console.Error.WriteLineAsync($"[RiotApiClient] Unexpected error while sending GET request to {url}: {e.Message}");
        }
        
        return null;
    }

    public async Task<LeagueEntry[]> GetLeagueEntriesAsync(
        Region region,
        Queue queue,
        Tier tier,
        Division division,
        int page = 1
    )
    {
        var route = RegionalToString(region);
        var path = $"lol/league-exp/v4/entries/{queue}/{tier}/{division}?page={page}";
        return await SendGetAsync<LeagueEntry[]>(route, path) ?? [];
    }

    public async Task<Match?> GetMatchAsync(
        RegionalRoute regionalRoute,
        string matchId
    )
    {
        var route = RegionalRouteToString(regionalRoute);
        var path = $"lol/match/v5/matches/{matchId}";
        return await SendGetAsync<Match>(route, path) ?? null;
    }

    public async Task<string[]> GetMatchIdsForPuuidAsync(
        RegionalRoute regionalRoute,
        string puuid,
        long startTime = 0,
        long endTime = 0,
        int queue = 0,
        int start = 0,
        int count = 20
    )
    {
        var route = RegionalRouteToString(regionalRoute);
        var path = $"lol/match/v5/matches/by-puuid/{puuid}/ids?start={start}&count={count}";
        if (startTime is not 0) path += $"&startTime={startTime}";
        if (endTime is not 0) path += $"&endTime={endTime}";
        if (queue is not 0) path += $"&queue={queue}";
        return await SendGetAsync<string[]>(route, path) ?? [];
    }
    
    public void Dispose() => _httpClient.Dispose();
    
    private static string RegionalRouteToString(RegionalRoute regionalRoute) => regionalRoute.ToString().ToLowerInvariant();
    private static string RegionalToString(Region region) => region.ToString().ToLowerInvariant();
}