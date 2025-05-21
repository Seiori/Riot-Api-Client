using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Participant
{
    [JsonPropertyName("allInPings")]
    public int AllInPings { get; init; }

    [JsonPropertyName("assistMePings")]
    public int AssistMePings { get; init; }

    [JsonPropertyName("assists")]
    public int Assists { get; init; }

    [JsonPropertyName("baronKills")]
    public int BaronKills { get; init; }

    [JsonPropertyName("basicPings")]
    public int BasicPings { get; init; }
    
    [JsonPropertyName("bountyLevel")]
    public int BountyLevel { get; init; }

    [JsonPropertyName("champExperience")]
    public int ChampExperience { get; init; }

    [JsonPropertyName("champLevel")]
    public int ChampLevel { get; init; }

    [JsonPropertyName("championId")]
    public int ChampionId { get; init; }

    [JsonPropertyName("championName")]
    public string ChampionName { get; init; }

    [JsonPropertyName("commandPings")]
    public int CommandPings { get; init; }

    [JsonPropertyName("championTransform")]
    public int ChampionTransform { get; init; }

    [JsonPropertyName("consumablesPurchased")]
    public int ConsumablesPurchased { get; init; }

    [JsonPropertyName("challenges")]
    public Challenges Challenges { get; init; }

    [JsonPropertyName("damageDealtToBuildings")]
    public int DamageDealtToBuildings { get; init; }

    [JsonPropertyName("damageDealtToObjectives")]
    public int DamageDealtToObjectives { get; init; }

    [JsonPropertyName("damageDealtToTurrets")]
    public int DamageDealtToTurrets { get; init; }

    [JsonPropertyName("damageSelfMitigated")]
    public int DamageSelfMitigated { get; init; }

    [JsonPropertyName("dangerPings")]
    public int DangerPings { get; init; }
    
    [JsonPropertyName("deaths")]
    public int Deaths { get; init; }

    [JsonPropertyName("detectorWardsPlaced")]
    public int DetectorWardsPlaced { get; init; }

    [JsonPropertyName("doubleKills")]
    public int DoubleKills { get; init; }

    [JsonPropertyName("dragonKills")]
    public int DragonKills { get; init; }

    [JsonPropertyName("eligibleForProgression")]
    public bool EligibleForProgression { get; init; }

    [JsonPropertyName("enemyMissingPings")]
    public int EnemyMissingPings { get; init; }

    [JsonPropertyName("enemyVisionPings")]
    public int EnemyVisionPings { get; init; }

    [JsonPropertyName("firstBloodAssist")]
    public bool FirstBloodAssist { get; init; }

    [JsonPropertyName("firstBloodKill")]
    public bool FirstBloodKill { get; init; }

    [JsonPropertyName("firstTowerAssist")]
    public bool FirstTowerAssist { get; init; }

    [JsonPropertyName("firstTowerKill")]
    public bool FirstTowerKill { get; init; }

    [JsonPropertyName("gameEndedInEarlySurrender")]
    public bool GameEndedInEarlySurrender { get; init; }

    [JsonPropertyName("gameEndedInSurrender")]
    public bool GameEndedInSurrender { get; init; }

    [JsonPropertyName("holdPings")]
    public int HoldPings { get; init; }

    [JsonPropertyName("getBackPings")]
    public int GetBackPings { get; init; }

    [JsonPropertyName("goldEarned")]
    public int GoldEarned { get; init; }

    [JsonPropertyName("goldSpent")]
    public int GoldSpent { get; init; }

    [JsonPropertyName("individualPosition")]
    public string IndividualPosition { get; init; }

    [JsonPropertyName("inhibitorKills")]
    public int InhibitorKills { get; init; }

    [JsonPropertyName("inhibitorTakedowns")]
    public int InhibitorTakedowns { get; init; }

    [JsonPropertyName("inhibitorsLost")]
    public int InhibitorsLost { get; init; }

    [JsonPropertyName("item0")]
    public int Item0 { get; init; }

    [JsonPropertyName("item1")]
    public int Item1 { get; init; }

    [JsonPropertyName("item2")]
    public int Item2 { get; init; }

    [JsonPropertyName("item3")]
    public int Item3 { get; init; }

    [JsonPropertyName("item4")]
    public int Item4 { get; init; }

    [JsonPropertyName("item5")]
    public int Item5 { get; init; }

    [JsonPropertyName("item6")]
    public int Item6 { get; init; }

    [JsonPropertyName("itemsPurchased")]
    public int ItemsPurchased { get; init; }

    [JsonPropertyName("killingSprees")]
    public int KillingSprees { get; init; }

    [JsonPropertyName("kills")]
    public int Kills { get; init; }

    [JsonPropertyName("lane")]
    public string Lane { get; init; }

    [JsonPropertyName("largestCriticalStrike")]
    public int LargestCriticalStrike { get; init; }

    [JsonPropertyName("largestKillingSpree")]
    public int LargestKillingSpree { get; init; }

    [JsonPropertyName("largestMultiKill")]
    public int LargestMultiKill { get; init; }

    [JsonPropertyName("longestTimeSpentLiving")]
    public int LongestTimeSpentLiving { get; init; }

    [JsonPropertyName("magicDamageDealt")]
    public int MagicDamageDealt { get; init; }

    [JsonPropertyName("magicDamageDealtToChampions")]
    public int MagicDamageDealtToChampions { get; init; }

    [JsonPropertyName("magicDamageTaken")]
    public int MagicDamageTaken { get; init; }

    [JsonPropertyName("missions")]
    public Missions Missions { get; init; } = new();

    [JsonPropertyName("neutralMinionsKilled")]
    public int NeutralMinionsKilled { get; init; }

    [JsonPropertyName("needVisionPings")]
    public int NeedVisionPings { get; init; }

    [JsonPropertyName("nexusKills")]
    public int NexusKills { get; init; }

    [JsonPropertyName("nexusTakedowns")]
    public int NexusTakedowns { get; init; }

    [JsonPropertyName("nexusLost")]
    public int NexusLost { get; init; }

    [JsonPropertyName("objectivesStolen")]
    public int ObjectivesStolen { get; init; }

    [JsonPropertyName("objectivesStolenAssists")]
    public int ObjectivesStolenAssists { get; init; }

    [JsonPropertyName("onMyWayPings")]
    public int OnMyWayPings { get; init; }

    [JsonPropertyName("participantId")]
    public int ParticipantId { get; init; }

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

    [JsonPropertyName("pentaKills")]
    public int PentaKills { get; init; }

    [JsonPropertyName("perks")]
    public Perks Perks { get; init; } = new();

    [JsonPropertyName("physicalDamageDealt")]
    public int PhysicalDamageDealt { get; init; }

    [JsonPropertyName("physicalDamageDealtToChampions")]
    public int PhysicalDamageDealtToChampions { get; init; }

    [JsonPropertyName("physicalDamageTaken")]
    public int PhysicalDamageTaken { get; init; }

    [JsonPropertyName("placement")]
    public int Placement { get; init; }

    [JsonPropertyName("playerAugment1")]
    public int PlayerAugment1 { get; init; }

    [JsonPropertyName("playerAugment2")]
    public int PlayerAugment2 { get; init; }

    [JsonPropertyName("playerAugment3")]
    public int PlayerAugment3 { get; init; }

    [JsonPropertyName("playerAugment4")]
    public int PlayerAugment4 { get; init; }

    [JsonPropertyName("playerSubTeamId")]
    public int PlayerSubTeamId { get; init; }

    [JsonPropertyName("pushPings")]
    public int PushPings { get; init; }

    [JsonPropertyName("profileIcon")]
    public int ProfileIcon { get; init; }

    [JsonPropertyName("puuid")]
    public string Puuid { get; init; }

    [JsonPropertyName("quadraKills")]
    public int QuadraKills { get; init; }

    [JsonPropertyName("retreatPings")]
    public int RetreatPings { get; init; }
    
    [JsonPropertyName("riotIdGameName")]
    public string RiotIdGameName { get; init; }

    [JsonPropertyName("riotIdTagline")]
    public string RiotIdTagline { get; init; }

    [JsonPropertyName("role")]
    public string Role { get; init; }

    [JsonPropertyName("sightWardsBoughtInGame")]
    public int SightWardsBoughtInGame { get; init; }

    [JsonPropertyName("spell1Casts")]
    public int Spell1Casts { get; init; }

    [JsonPropertyName("spell2Casts")]
    public int Spell2Casts { get; init; }

    [JsonPropertyName("spell3Casts")]
    public int Spell3Casts { get; init; }

    [JsonPropertyName("spell4Casts")]
    public int Spell4Casts { get; init; }

    [JsonPropertyName("subteamPlacement")]
    public int SubteamPlacement { get; init; }

    [JsonPropertyName("summoner1Casts")]
    public int Summoner1Casts { get; init; }

    [JsonPropertyName("summoner1Id")]
    public int Summoner1Id { get; init; }

    [JsonPropertyName("summoner2Casts")]
    public int Summoner2Casts { get; init; }

    [JsonPropertyName("summoner2Id")]
    public int Summoner2Id { get; init; }

    [JsonPropertyName("summonerId")]
    public string SummonerId { get; init; }

    [JsonPropertyName("summonerLevel")]
    public int SummonerLevel { get; init; }

    [JsonPropertyName("summonerName")]
    public string SummonerName { get; init; }

    [JsonPropertyName("teamEarlySurrendered")]
    public bool TeamEarlySurrendered { get; init; }

    [JsonPropertyName("teamId")]
    public int TeamId { get; init; }

    [JsonPropertyName("teamPosition")]
    public string TeamPosition { get; init; }

    [JsonPropertyName("timeCCingOthers")]
    public int TimeCCingOthers { get; init; }

    [JsonPropertyName("timePlayed")]
    public int TimePlayed { get; init; }

    [JsonPropertyName("totalAllyJungleMinionsKilled")]
    public int TotalAllyJungleMinionsKilled { get; init; }

    [JsonPropertyName("totalDamageDealt")]
    public int TotalDamageDealt { get; init; }

    [JsonPropertyName("totalDamageDealtToChampions")]
    public int TotalDamageDealtToChampions { get; init; }

    [JsonPropertyName("totalDamageShieldedOnTeammates")]
    public int TotalDamageShieldedOnTeammates { get; init; }

    [JsonPropertyName("totalDamageTaken")]
    public int TotalDamageTaken { get; init; }

    [JsonPropertyName("totalEnemyJungleMinionsKilled")]
    public int TotalEnemyJungleMinionsKilled { get; init; }

    [JsonPropertyName("totalHeal")]
    public int TotalHeal { get; init; }

    [JsonPropertyName("totalHealsOnTeammates")]
    public int TotalHealsOnTeammates { get; init; }

    [JsonPropertyName("totalMinionsKilled")]
    public int TotalMinionsKilled { get; init; }

    [JsonPropertyName("totalTimeCCDealt")]
    public int TotalTimeCCDealt { get; init; }

    [JsonPropertyName("totalTimeSpentDead")]
    public int TotalTimeSpentDead { get; init; }

    [JsonPropertyName("totalUnitsHealed")]
    public int TotalUnitsHealed { get; init; }

    [JsonPropertyName("tripleKills")]
    public int TripleKills { get; init; }

    [JsonPropertyName("trueDamageDealt")]
    public int TrueDamageDealt { get; init; }

    [JsonPropertyName("trueDamageDealtToChampions")]
    public int TrueDamageDealtToChampions { get; init; }

    [JsonPropertyName("trueDamageTaken")]
    public int TrueDamageTaken { get; init; }

    [JsonPropertyName("turretKills")]
    public int TurretKills { get; init; }

    [JsonPropertyName("turretTakedowns")]
    public int TurretTakedowns { get; init; }

    [JsonPropertyName("turretsLost")]
    public int TurretsLost { get; init; }

    [JsonPropertyName("unrealKills")]
    public int UnrealKills { get; init; }

    [JsonPropertyName("visionScore")]
    public int VisionScore { get; init; }

    [JsonPropertyName("visionClearedPings")]
    public int VisionClearedPings { get; init; }

    [JsonPropertyName("visionWardsBoughtInGame")]
    public int VisionWardsBoughtInGame { get; init; }

    [JsonPropertyName("wardsKilled")]
    public int WardsKilled { get; init; }

    [JsonPropertyName("wardsPlaced")]
    public int WardsPlaced { get; init; }

    [JsonPropertyName("win")]
    public bool Win { get; init; }
}