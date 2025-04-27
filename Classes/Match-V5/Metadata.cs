using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Metadata
{
    [JsonPropertyName("dataVersion")]
    string DataVersion { get; init; }
    
    [JsonPropertyName("matchId")]
    string MatchId { get; init; }
    
    [JsonPropertyName("participants")]
    string[] Participants { get; init; }
}