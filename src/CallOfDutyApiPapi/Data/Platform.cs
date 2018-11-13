using System;

namespace CallOfDutyApiPapi.Data
{
    public enum Platform
    {
        Playstation,
        Steam,
        Xbox,
        BattleNet
    }

    internal static class PlatformExtensions
    {
        public static string ToKey(this Platform platform)
        {
            switch (platform)
            {
                case Platform.Playstation:
                    return "psn";
                case Platform.Steam:
                    return "steam";
                case Platform.Xbox:
                    return "xbl";
                case Platform.BattleNet:
                    return "battle";
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
    }
}
