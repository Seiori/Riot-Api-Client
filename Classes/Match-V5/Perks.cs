using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Perks
{
    [JsonPropertyName("statPerks")]
    public PerkStats PerkStats { get; init; } = new();

    [JsonPropertyName("styles")]
    public PerkStyle[] Styles { get; init; } = [];
}