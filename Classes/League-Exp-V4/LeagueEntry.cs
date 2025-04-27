using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.League_Exp_V4;

public record LeagueEntry(
    [property: JsonPropertyName("leagueId")]
    string LeagueId,

    [property: JsonPropertyName("summonerId")]
    string SummonerId,

    [property: JsonPropertyName("puuid")] 
    string Puuid,

    [property: JsonPropertyName("queueType")]
    string QueueType,

    [property: JsonPropertyName("tier")]
    string Tier,

    [property: JsonPropertyName("rank")] 
    string Rank,

    [property: JsonPropertyName("leaguePoints")]
    int LeaguePoints,

    [property: JsonPropertyName("wins")] 
    int Wins,

    [property: JsonPropertyName("losses")] 
    int Losses,

    [property: JsonPropertyName("hotStreak")]
    bool HotStreak,

    [property: JsonPropertyName("veteran")]
    bool Veteran,

    [property: JsonPropertyName("freshBlood")]
    bool FreshBlood,

    [property: JsonPropertyName("inactive")]
    bool Inactive,

    [property: JsonPropertyName("miniSeries")]
    MiniSeries MiniSeries
);