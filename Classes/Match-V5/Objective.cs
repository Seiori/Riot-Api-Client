using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Objective
{
    [JsonPropertyName("first")]
    public bool First { get; init; }
    
    [JsonPropertyName("kills")]
    public int Kills { get; init; }
}