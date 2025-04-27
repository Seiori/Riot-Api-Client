using System.Text.Json.Serialization;

namespace Seiori.RiotAPI.Classes.Match_V5;

public record Challenges
{
    [JsonPropertyName("12AssistStreakCount")]
    public int AssistStreakCount { get; init; }

    [JsonPropertyName("HealFromMapSources")]
    public decimal HealFromMapSources { get; init; }

    [JsonPropertyName("InfernalScalePickup")]
    public int InfernalScalePickup { get; init; }

    [JsonPropertyName("SWARM_DefeatAatrox")]
    public int SwarmDefeatAatrox { get; init; }

    [JsonPropertyName("SWARM_DefeatBriar")]
    public int SwarmDefeatBriar { get; init; }

    [JsonPropertyName("SWARM_DefeatMiniBosses")]
    public int SwarmDefeatMiniBosses { get; init; }

    [JsonPropertyName("SWARM_EvolveWeapon")]
    public int SwarmEvolveWeapon { get; init; }

    [JsonPropertyName("SWARM_Have3Passives")]
    public int SwarmHave3Passives { get; init; }

    [JsonPropertyName("SWARM_KillEnemy")]
    public int SwarmKillEnemy { get; init; }

    [JsonPropertyName("SWARM_PickupGold")]
    public float SwarmPickupGold { get; init; }

    [JsonPropertyName("SWARM_ReachLevel50")]
    public int SwarmReachLevel50 { get; init; }

    [JsonPropertyName("SWARM_Survive15Min")]
    public int SwarmSurvive15Min { get; init; }

    [JsonPropertyName("SWARM_WinWith5EvolvedWeapons")]
    public int SwarmWinWith5EvolvedWeapons { get; init; }

    [JsonPropertyName("abilityUses")]
    public int AbilityUses { get; init; }

    [JsonPropertyName("acesBefore15Minutes")]
    public int AcesBefore15Minutes { get; init; }

    [JsonPropertyName("alliedJungleMonsterKills")]
    public float AlliedJungleMonsterKills { get; init; }

    [JsonPropertyName("baronTakedowns")]
    public int BaronTakedowns { get; init; }

    [JsonPropertyName("blastConeOppositeOpponentCount")]
    public int BlastConeOppositeOpponentCount { get; init; }

    [JsonPropertyName("bountyGold")]
    public decimal BountyGold { get; init; }

    [JsonPropertyName("buffsStolen")]
    public int BuffsStolen { get; init; }

    [JsonPropertyName("completeSupportQuestInTime")]
    public int CompleteSupportQuestInTime { get; init; }

    [JsonPropertyName("controlWardTimeCoverageInRiverOrEnemyHalf")]
    public float ControlWardTimeCoverageInRiverOrEnemyHalf { get; init; }

    [JsonPropertyName("controlWardsPlaced")]
    public int ControlWardsPlaced { get; init; }

    [JsonPropertyName("damagePerMinute")]
    public float DamagePerMinute { get; init; }

    [JsonPropertyName("damageTakenOnTeamPercentage")]
    public float DamageTakenOnTeamPercentage { get; init; }

    [JsonPropertyName("dancedWithRiftHerald")]
    public int DancedWithRiftHerald { get; init; }

    [JsonPropertyName("deathsByEnemyChamps")]
    public int DeathsByEnemyChamps { get; init; }

    [JsonPropertyName("dodgeSkillShotsSmallWindow")]
    public int DodgeSkillShotsSmallWindow { get; init; }

    [JsonPropertyName("doubleAces")]
    public int DoubleAces { get; init; }

    [JsonPropertyName("dragonTakedowns")]
    public int DragonTakedowns { get; init; }

    [JsonPropertyName("earlyLaningPhaseGoldExpAdvantage")]
    public int EarlyLaningPhaseGoldExpAdvantage { get; init; }

    [JsonPropertyName("effectiveHealAndShielding")]
    public float EffectiveHealAndShielding { get; init; }

    [JsonPropertyName("elderDragonKillsWithOpposingSoul")]
    public int ElderDragonKillsWithOpposingSoul { get; init; }

    [JsonPropertyName("elderDragonMultikills")]
    public int ElderDragonMultikills { get; init; }

    [JsonPropertyName("enemyChampionImmobilizations")]
    public int EnemyChampionImmobilizations { get; init; }

    [JsonPropertyName("enemyJungleMonsterKills")]
    public float EnemyJungleMonsterKills { get; init; }

    [JsonPropertyName("epicMonsterKillsNearEnemyJungler")]
    public int EpicMonsterKillsNearEnemyJungler { get; init; }

    [JsonPropertyName("epicMonsterKillsWithin30SecondsOfSpawn")]
    public int EpicMonsterKillsWithin30SecondsOfSpawn { get; init; }

    [JsonPropertyName("epicMonsterSteals")]
    public int EpicMonsterSteals { get; init; }

    [JsonPropertyName("epicMonsterStolenWithoutSmite")]
    public int EpicMonsterStolenWithoutSmite { get; init; }

    [JsonPropertyName("firstTurretKilled")]
    public int FirstTurretKilled { get; init; }

    [JsonPropertyName("firstTurretKilledTime")]
    public float FirstTurretKilledTime { get; init; }

    [JsonPropertyName("fistBumpParticipation")]
    public int FistBumpParticipation { get; init; }

    [JsonPropertyName("flawlessAces")]
    public int FlawlessAces { get; init; }

    [JsonPropertyName("fullTeamTakedown")]
    public int FullTeamTakedown { get; init; }

    [JsonPropertyName("gameLength")]
    public float GameLength { get; init; }

    [JsonPropertyName("getTakedownsInAllLanesEarlyJungleAsLaner")]
    public int GetTakedownsInAllLanesEarlyJungleAsLaner { get; init; }

    [JsonPropertyName("goldPerMinute")]
    public float GoldPerMinute { get; init; }

    [JsonPropertyName("hadOpenNexus")]
    public int HadOpenNexus { get; init; }

    [JsonPropertyName("immobilizeAndKillWithAlly")]
    public int ImmobilizeAndKillWithAlly { get; init; }

    [JsonPropertyName("initialBuffCount")]
    public int InitialBuffCount { get; init; }

    [JsonPropertyName("initialCrabCount")]
    public int InitialCrabCount { get; init; }

    [JsonPropertyName("jungleCsBefore10Minutes")]
    public float JungleCsBefore10Minutes { get; init; }

    [JsonPropertyName("junglerTakedownsNearDamagedEpicMonster")]
    public int JunglerTakedownsNearDamagedEpicMonster { get; init; }

    [JsonPropertyName("kTurretsDestroyedBeforePlatesFall")]
    public int KTurretsDestroyedBeforePlatesFall { get; init; }

    [JsonPropertyName("kda")]
    public float Kda { get; init; }

    [JsonPropertyName("killAfterHiddenWithAlly")]
    public int KillAfterHiddenWithAlly { get; init; }

    [JsonPropertyName("killParticipation")]
    public float KillParticipation { get; init; }

    [JsonPropertyName("killedChampTookFullTeamDamageSurvived")]
    public int KilledChampTookFullTeamDamageSurvived { get; init; }

    [JsonPropertyName("killingSprees")]
    public int KillingSprees { get; init; }

    [JsonPropertyName("killsNearEnemyTurret")]
    public int KillsNearEnemyTurret { get; init; }

    [JsonPropertyName("killsOnOtherLanesEarlyJungleAsLaner")]
    public int KillsOnOtherLanesEarlyJungleAsLaner { get; init; }

    [JsonPropertyName("killsOnRecentlyHealedByAramPack")]
    public int KillsOnRecentlyHealedByAramPack { get; init; }

    [JsonPropertyName("killsUnderOwnTurret")]
    public int KillsUnderOwnTurret { get; init; }

    [JsonPropertyName("killsWithHelpFromEpicMonster")]
    public int KillsWithHelpFromEpicMonster { get; init; }

    [JsonPropertyName("knockEnemyIntoTeamAndKill")]
    public int KnockEnemyIntoTeamAndKill { get; init; }

    [JsonPropertyName("landSkillShotsEarlyGame")]
    public int LandSkillShotsEarlyGame { get; init; }

    [JsonPropertyName("laneMinionsFirst10Minutes")]
    public int LaneMinionsFirst10Minutes { get; init; }

    [JsonPropertyName("laningPhaseGoldExpAdvantage")]
    public int LaningPhaseGoldExpAdvantage { get; init; }

    [JsonPropertyName("legendaryCount")]
    public int LegendaryCount { get; init; }

    [JsonPropertyName("legendaryItemUsed")]
    public int[] LegendaryItemUsed { get; init; } = [];

    [JsonPropertyName("lostAnInhibitor")]
    public int LostAnInhibitor { get; init; }

    [JsonPropertyName("maxCsAdvantageOnLaneOpponent")]
    public float MaxCsAdvantageOnLaneOpponent { get; init; }

    [JsonPropertyName("maxKillDeficit")]
    public int MaxKillDeficit { get; init; }

    [JsonPropertyName("maxLevelLeadLaneOpponent")]
    public int MaxLevelLeadLaneOpponent { get; init; }

    [JsonPropertyName("mejaisFullStackInTime")]
    public int MejaisFullStackInTime { get; init; }

    [JsonPropertyName("moreEnemyJungleThanOpponent")]
    public float MoreEnemyJungleThanOpponent { get; init; }

    [JsonPropertyName("multiKillOneSpell")]
    public int MultiKillOneSpell { get; init; }

    [JsonPropertyName("multiTurretRiftHeraldCount")]
    public int MultiTurretRiftHeraldCount { get; init; }

    [JsonPropertyName("multikills")]
    public int Multikills { get; init; }

    [JsonPropertyName("multikillsAfterAggressiveFlash")]
    public int MultikillsAfterAggressiveFlash { get; init; }

    [JsonPropertyName("outerTurretExecutesBefore10Minutes")]
    public int OuterTurretExecutesBefore10Minutes { get; init; }

    [JsonPropertyName("outnumberedKills")]
    public int OutnumberedKills { get; init; }

    [JsonPropertyName("outnumberedNexusKill")]
    public int OutnumberedNexusKill { get; init; }

    [JsonPropertyName("perfectDragonSoulsTaken")]
    public int PerfectDragonSoulsTaken { get; init; }

    [JsonPropertyName("perfectGame")]
    public int PerfectGame { get; init; }

    [JsonPropertyName("pickKillWithAlly")]
    public int PickKillWithAlly { get; init; }

    [JsonPropertyName("playedChampSelectPosition")]
    public int PlayedChampSelectPosition { get; init; }

    [JsonPropertyName("poroExplosions")]
    public int PoroExplosions { get; init; }

    [JsonPropertyName("quickCleanse")]
    public int QuickCleanse { get; init; }

    [JsonPropertyName("quickFirstTurret")]
    public int QuickFirstTurret { get; init; }

    [JsonPropertyName("quickSoloKills")]
    public int QuickSoloKills { get; init; }

    [JsonPropertyName("riftHeraldTakedowns")]
    public int RiftHeraldTakedowns { get; init; }

    [JsonPropertyName("saveAllyFromDeath")]
    public int SaveAllyFromDeath { get; init; }

    [JsonPropertyName("scuttleCrabKills")]
    public int ScuttleCrabKills { get; init; }

    [JsonPropertyName("shortestTimeToAceFromFirstTakedown")]
    public float ShortestTimeToAceFromFirstTakedown { get; init; }

    [JsonPropertyName("skillshotsDodged")]
    public int SkillshotsDodged { get; init; }

    [JsonPropertyName("skillshotsHit")]
    public int SkillshotsHit { get; init; }

    [JsonPropertyName("snowballsHit")]
    public int SnowballsHit { get; init; }

    [JsonPropertyName("soloBaronKills")]
    public int SoloBaronKills { get; init; }

    [JsonPropertyName("soloKills")]
    public int SoloKills { get; init; }

    [JsonPropertyName("stealthWardsPlaced")]
    public int StealthWardsPlaced { get; init; }

    [JsonPropertyName("survivedSingleDigitHpCount")]
    public int SurvivedSingleDigitHpCount { get; init; }

    [JsonPropertyName("survivedThreeImmobilizesInFight")]
    public int SurvivedThreeImmobilizesInFight { get; init; }

    [JsonPropertyName("takedownOnFirstTurret")]
    public int TakedownOnFirstTurret { get; init; }

    [JsonPropertyName("takedowns")]
    public int Takedowns { get; init; }

    [JsonPropertyName("takedownsAfterGainingLevelAdvantage")]
    public int TakedownsAfterGainingLevelAdvantage { get; init; }

    [JsonPropertyName("takedownsBeforeJungleMinionSpawn")]
    public int TakedownsBeforeJungleMinionSpawn { get; init; }

    [JsonPropertyName("takedownsFirstXMinutes")]
    public int TakedownsFirstXMinutes { get; init; }

    [JsonPropertyName("takedownsInAlcove")]
    public int TakedownsInAlcove { get; init; }

    [JsonPropertyName("takedownsInEnemyFountain")]
    public int TakedownsInEnemyFountain { get; init; }

    [JsonPropertyName("teamBaronKills")]
    public int TeamBaronKills { get; init; }

    [JsonPropertyName("teamDamagePercentage")]
    public float TeamDamagePercentage { get; init; }

    [JsonPropertyName("teamElderDragonKills")]
    public int TeamElderDragonKills { get; init; }

    [JsonPropertyName("teamRiftHeraldKills")]
    public int TeamRiftHeraldKills { get; init; }

    [JsonPropertyName("tookLargeDamageSurvived")]
    public int TookLargeDamageSurvived { get; init; }

    [JsonPropertyName("turretPlatesTaken")]
    public int TurretPlatesTaken { get; init; }

    [JsonPropertyName("turretTakedowns")]
    public int TurretTakedowns { get; init; }

    [JsonPropertyName("turretsTakenWithRiftHerald")]
    public int TurretsTakenWithRiftHerald { get; init; }

    [JsonPropertyName("twentyMinionsIn3SecondsCount")]
    public int TwentyMinionsIn3SecondsCount { get; init; }

    [JsonPropertyName("twoWardsOneSweeperCount")]
    public int TwoWardsOneSweeperCount { get; init; }

    [JsonPropertyName("unseenRecalls")]
    public int UnseenRecalls { get; init; }

    [JsonPropertyName("visionScoreAdvantageLaneOpponent")]
    public float VisionScoreAdvantageLaneOpponent { get; init; }

    [JsonPropertyName("visionScorePerMinute")]
    public float VisionScorePerMinute { get; init; }

    [JsonPropertyName("voidMonsterKill")]
    public int VoidMonsterKill { get; init; }

    [JsonPropertyName("wardTakedowns")]
    public int WardTakedowns { get; init; }

    [JsonPropertyName("wardTakedownsBefore20M")]
    public int WardTakedownsBefore20M { get; init; }

    [JsonPropertyName("wardsGuarded")]
    public int WardsGuarded { get; init; }
}