using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Info
{
    [JsonPropertyName("endOfGameResult")]
    public string EndOfGameResult { get; init; }

    [JsonPropertyName("gameCreation")]
    public long GameCreation { get; init; }

    [JsonPropertyName("gameDuration")]
    public long GameDuration { get; init; }

    [JsonPropertyName("gameEndTimestamp")]
    public long GameEndTimestamp { get; init; }

    [JsonPropertyName("gameId")]
    public long GameId { get; init; }

    [JsonPropertyName("gameMode")]
    public string GameMode { get; init; }

    [JsonPropertyName("gameName")]
    public string GameName { get; init; }

    [JsonPropertyName("gameStartTimestamp")]
    public long GameStartTimestamp { get; init; }

    [JsonPropertyName("gameType")]
    public string GameType { get; init; }

    [JsonPropertyName("gameVersion")]
    public string GameVersion { get; init; }

    [JsonPropertyName("mapId")]
    public int MapId { get; init; }

    [JsonPropertyName("participants")]
    public Participant[] Participants { get; init; } = [];

    [JsonPropertyName("platformId")]
    public string PlatformId { get; init; }

    [JsonPropertyName("queueId")]
    public int QueueId { get; init; }

    [JsonPropertyName("teams")]
    public Team[] Teams { get; init; } = [];

    [JsonPropertyName("tournamentCode")]
    public string TournamentCode { get; init; }
}