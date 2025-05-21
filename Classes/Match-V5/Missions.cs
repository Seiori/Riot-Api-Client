using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Missions
{
    [JsonPropertyName("playerScore0")]
    public decimal PlayerScore0 { get; init; }
    
    [JsonPropertyName("playerScore1")]
    public decimal PlayerScore1 { get; init; }
    
    [JsonPropertyName("playerScore2")]
    public decimal PlayerScore2 { get; init; }
    
    [JsonPropertyName("playerScore3")]
    public decimal PlayerScore3 { get; init; }
    
    [JsonPropertyName("playerScore4")]
    public decimal PlayerScore4 { get; init; }
    
    [JsonPropertyName("playerScore5")]
    public decimal PlayerScore5 { get; init; }
    
    [JsonPropertyName("playerScore6")]
    public decimal PlayerScore6 { get; init; }
    
    [JsonPropertyName("playerScore7")]
    public decimal PlayerScore7 { get; init; }
    
    [JsonPropertyName("playerScore8")]
    public decimal PlayerScore8 { get; init; }
    
    [JsonPropertyName("playerScore9")]
    public decimal PlayerScore9 { get; init; }
    
    [JsonPropertyName("playerScore10")]
    public decimal PlayerScore10 { get; init; }
    
    [JsonPropertyName("playerScore11")]
    public decimal PlayerScore11 { get; init; }
}