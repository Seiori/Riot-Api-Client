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
    private const string BaseUrl = "https://{0}.api.riotgames.com/";

    public RiotApiClient(RiotApiOptions options)
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("X-Riot-Token", options.Apikey);
        
        _jsonSerializerOptions = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        
        var handle429OrNetwork = Policy
            .Handle<HttpRequestException>()
            .OrResult<HttpResponseMessage>(r => r.StatusCode == (HttpStatusCode)429);

        _retryPolicy = options.RetryCount <= 0
            ? handle429OrNetwork.WaitAndRetryForeverAsync(
                _ => TimeSpan.FromSeconds(1),
                onRetry: (outcome, span, ctx) =>
                {
                    if (options.Debug)
                    {
                        Console.Error.WriteLine(
                            $"[RiotApiClient] retry forever after {span} " +
                            $"due to {(outcome.Exception != null
                                ? outcome.Exception.Message
                                : outcome.Result.StatusCode.ToString())}");
                    }
                })
            : handle429OrNetwork.WaitAndRetryAsync(
                options.RetryCount,
                _ => TimeSpan.FromSeconds(1),
                onRetry: (outcome, span, attempt, ctx) =>
                {
                    if (options.Debug)
                    {
                        Console.Error.WriteLine(
                            $"[RiotApiClient] retry {attempt}/{options.RetryCount} after {span} " +
                            $"due to {(outcome.Exception != null
                                ? outcome.Exception.Message
                                : outcome.Result.StatusCode.ToString())}");
                    }
                });
    }

    private async Task<T> SendGetAsync<T>(string route, string path)
    {
        var baseUrl = string.Format(BaseUrl, route);
        var url = $"{baseUrl}{path}";
        var response = await _retryPolicy.ExecuteAsync(() => _httpClient.GetAsync(url));
        response.EnsureSuccessStatusCode();
        
        await using var stream = await response.Content.ReadAsStreamAsync();
        var result = await JsonSerializer.DeserializeAsync<T>(stream, _jsonSerializerOptions);
        if (result is null) throw new JsonException($"Failed to deserialize response from {path}");
        
        return result;
    }

    public Task<LeagueEntry[]> GetLeagueEntriesAsync(
        Region region,
        Queue queue,
        Tier tier,
        Division division,
        int page = 1
    )
    {
        var route = RegionalToString(region);
        var path = $"lol/league-exp/v4/entries/{queue}/{tier}/{division}?page={page}";
        return SendGetAsync<LeagueEntry[]>(route, path);
    }

    public Task<Match> GetMatchAsync(
        RegionalRoute regionalRoute,
        string matchId
    )
    {
        var route = RegionalRouteToString(regionalRoute);
        var path = $"lol/match/v5/matches/{matchId}";
        return SendGetAsync<Match>(route, path);
    }

    public Task<string[]> GetMatchIdsForPuuidAsync(
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
        var path = $"lol/match/v5/matches/by-puuid/{puuid}/ids?startTime={startTime}&endTime={endTime}&queue={queue}&start={start}&count={count}";
        return SendGetAsync<string[]>(route, path);
    }
    
    public void Dispose() => _httpClient.Dispose();
    
    private static string RegionalRouteToString(RegionalRoute regionalRoute) => regionalRoute.ToString().ToLowerInvariant();
    private static string RegionalToString(Region region) => region.ToString().ToLowerInvariant();
}