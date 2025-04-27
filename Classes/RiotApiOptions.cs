using Seiori.RiotAPI.Enums;

namespace Seiori.RiotAPI.Classes;

public class RiotApiOptions
{
    public required string Apikey { get; init; }
    public RegionalRoute RegionalRoute { get; init; } = RegionalRoute.Europe;
    public int RetryCount { get; init; } = 0;
    public bool Debug { get; init; } = false;
}