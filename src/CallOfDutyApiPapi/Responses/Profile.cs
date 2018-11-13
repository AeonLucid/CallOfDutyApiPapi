using System.Collections.Generic;
using Newtonsoft.Json;

namespace CallOfDutyApiPapi.Responses
{
    public class Profile
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("mp")]
        public ProfileMultiplayer Mp { get; set; }
    }

    public class ProfileMultiplayer
    {
        [JsonProperty("lifetime")]
        public ProfileMultiplayerData Lifetime { get; set; }

        [JsonProperty("weekly")]
        public ProfileMultiplayerData Weekly { get; set; }

        [JsonProperty("level")]
        public long Level { get; set; }

        [JsonProperty("maxLevel")]
        public long MaxLevel { get; set; }

        [JsonProperty("levelXpRemainder")]
        public long LevelXpRemainder { get; set; }

        [JsonProperty("levelXpGained")]
        public long LevelXpGained { get; set; }

        [JsonProperty("prestige")]
        public long Prestige { get; set; }

        [JsonProperty("prestigeId")]
        public long PrestigeId { get; set; }

        [JsonProperty("maxPrestige")]
        public long MaxPrestige { get; set; }
    }

    public class ProfileMultiplayerData
    {
        [JsonProperty("all")]
        public Dictionary<string, double> All { get; set; }

        [JsonProperty("mode")]
        public Dictionary<string, Dictionary<string, double>> Mode { get; set; }

        [JsonProperty("map")]
        public Dictionary<string, Dictionary<string, Dictionary<string, double>>> Map { get; set; }
    }
}
