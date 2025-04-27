using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Feat
{
    [JsonPropertyName("featState")]
    public int FeatState { get; init; }
}