using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Ban
{
    [JsonPropertyName("championId")]
    public int ChampionId { get; init; }
    
    [JsonPropertyName("pickTurn")]
    public int PickTurn { get; init; }
}