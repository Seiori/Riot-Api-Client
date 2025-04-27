using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Objectives
{
    [JsonPropertyName("baron")]
    public Objective Baron { get; init; } = new();

    [JsonPropertyName("champion")]
    public Objective Champion { get; init; } = new();

    [JsonPropertyName("dragon")]
    public Objective Dragon { get; init; } = new();
    
    [JsonPropertyName("horde")]
    public Objective Horde { get; init; } = new();

    [JsonPropertyName("inhibitor")]
    public Objective Inhibitor { get; init; } = new();

    [JsonPropertyName("riftHerald")]
    public Objective RiftHerald { get; init; } = new();

    [JsonPropertyName("tower")]
    public Objective Tower { get; init; } = new();
}