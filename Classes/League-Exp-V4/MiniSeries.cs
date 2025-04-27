using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.League_Exp_V4;

public record MiniSeries(
    [property: JsonPropertyName("losses")]
    int Losses,
    
    [property: JsonPropertyName("progress")]
    string Progress,
    
    [property: JsonPropertyName("target")]
    int Target,
    
    [property: JsonPropertyName("wins")]
    int Wins
);