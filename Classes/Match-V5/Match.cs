using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Match
{
    [JsonPropertyName("metadata")]
    public Metadata Metadata { get; init; } = new();

    [JsonPropertyName("info")]
    public Info Info { get; init; } = new();
}