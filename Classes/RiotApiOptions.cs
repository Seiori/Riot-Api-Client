using Seiori.RiotAPI.Enums;

namespace Seiori.RiotAPI.Classes;

public class RiotApiOptions
{
    public required string Apikey { get; init; }
    public RegionalRoute RegionalRoute { get; init; } = RegionalRoute.Europe;
    public int RetryCount { get; init; } = 3;
    public double ExponentialBackoffBase { get; init; } = 2.0;
    public TimeSpan MinRetryDelay { get; init; } = TimeSpan.FromSeconds(1);
    public bool Debug { get; init; } = false;
}