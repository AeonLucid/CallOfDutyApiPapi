using System.Collections.Generic;
using Newtonsoft.Json;

namespace CallOfDutyApiPapi.Responses
{
    public class RecentMatches
    {
        [JsonProperty("summary")]
        public Dictionary<string, Dictionary<string, double>> Summary { get; set; }

        [JsonProperty("matches")]
        public List<RecentMatch> Matches { get; set; }
    }

    public class RecentMatch
    {
        [JsonProperty("utcStartSeconds")]
        public long UtcStartSeconds { get; set; }

        [JsonProperty("utcEndSeconds")]
        public long UtcEndSeconds { get; set; }

        [JsonProperty("map")]
        public string Map { get; set; }

        [JsonProperty("mode")]
        public string Mode { get; set; }

        [JsonProperty("matchID")]
        public string MatchId { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }

        [JsonProperty("gameType")]
        public string GameType { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("winningTeam")]
        public string WinningTeam { get; set; }

        [JsonProperty("gameBattle")]
        public bool GameBattle { get; set; }

        [JsonProperty("playlistName")]
        public object PlaylistName { get; set; }

        [JsonProperty("team1Score")]
        public long Team1Score { get; set; }

        [JsonProperty("team2Score")]
        public long Team2Score { get; set; }

        [JsonProperty("isPresentAtEnd")]
        public bool IsPresentAtEnd { get; set; }

        [JsonProperty("player")]
        public RecentMatchPlayer Player { get; set; }

        [JsonProperty("playerStats")]
        public Dictionary<string, double> PlayerStats { get; set; }

        [JsonProperty("arena")]
        public bool Arena { get; set; }

        [JsonProperty("privateMatch")]
        public bool PrivateMatch { get; set; }
    }

    public class RecentMatchPlayer
    {
        [JsonProperty("team")]
        public string Team { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("prestige")]
        public long Prestige { get; set; }
    }
}
