using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record PerkStyle
{
    [JsonPropertyName("description")]
    public string Description { get; init; } = string.Empty;

    [JsonPropertyName("selections")]
    public PerkStyleSelection[] Selections { get; init; } = [];

    [JsonPropertyName("style")]
    public int Style { get; init; }
}