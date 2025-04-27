using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Team
{
    [JsonPropertyName("bans")]
    public Ban[] Bans { get; init; } = [];

    [JsonPropertyName("feats")]
    public Feats Feats { get; init; } = new();
    
    [JsonPropertyName("objectives")]
    public Objectives Objectives { get; init; } = new();

    [JsonPropertyName("teamId")]
    public int TeamId { get; init; }

    [JsonPropertyName("win")]
    public bool Win { get; init; }
}