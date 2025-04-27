using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Feats
{
    [JsonPropertyName("EPIC_MONSTER_KILL")]
    public Feat EpicMonsterKill { get; init; } = new();
    
    [JsonPropertyName("FIRST_BLOOD")]
    public Feat FirstBlood { get; init; } = new();
    
    [JsonPropertyName("FIRST_TURRET")]
    public Feat FirstTurret { get; init; } = new();
}