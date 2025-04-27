using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record PerkStats
{
    [JsonPropertyName("defense")]
    public int Defense { get; init; }
    
    [JsonPropertyName("flex")]
    public int Flex { get; init; }
    
    [JsonPropertyName("offense")]
    public int Offense { get; init; }
}