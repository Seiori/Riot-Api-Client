using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Missions
{
    [JsonPropertyName("playerScore0")]
    public int PlayerScore0 { get; init; }
    
    [JsonPropertyName("playerScore1")]
    public int PlayerScore1 { get; init; }
    
    [JsonPropertyName("playerScore2")]
    public int PlayerScore2 { get; init; }
    
    [JsonPropertyName("playerScore3")]
    public int PlayerScore3 { get; init; }
    
    [JsonPropertyName("playerScore4")]
    public int PlayerScore4 { get; init; }
    
    [JsonPropertyName("playerScore5")]
    public int PlayerScore5 { get; init; }
    
    [JsonPropertyName("playerScore6")]
    public int PlayerScore6 { get; init; }
    
    [JsonPropertyName("playerScore7")]
    public int PlayerScore7 { get; init; }
    
    [JsonPropertyName("playerScore8")]
    public int PlayerScore8 { get; init; }
    
    [JsonPropertyName("playerScore9")]
    public int PlayerScore9 { get; init; }
    
    [JsonPropertyName("playerScore10")]
    public int PlayerScore10 { get; init; }
    
    [JsonPropertyName("playerScore11")]
    public int PlayerScore11 { get; init; }
}