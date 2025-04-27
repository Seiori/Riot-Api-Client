using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record PerkStyleSelection
{
    [JsonPropertyName("perk")]
    public int Perk { get; init; }

    [JsonPropertyName("var1")]
    public int Var1 { get; init; }

    [JsonPropertyName("var2")]
    public int Var2 { get; init; }

    [JsonPropertyName("var3")]
    public int Var3 { get; init; }
}