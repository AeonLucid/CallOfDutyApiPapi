using System;

namespace CallOfDutyApiPapi.Data
{
    public enum LeaderboardDuration
    {
        AllTime,
        Monthly,
        Weekly
    }

    internal static class LeaderboardDurationExtensions
    {
        public static string ToKey(this LeaderboardDuration leaderboardDuration)
        {
            switch (leaderboardDuration)
            {
                case LeaderboardDuration.AllTime:
                    return "alltime";
                case LeaderboardDuration.Monthly:
                    return "monthly";
                case LeaderboardDuration.Weekly:
                    return "weekly";
                default:
                    throw new ArgumentOutOfRangeException(nameof(leaderboardDuration), leaderboardDuration, null);
            }
        }
    }
}
