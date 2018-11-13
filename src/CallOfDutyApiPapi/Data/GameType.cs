using System;

namespace CallOfDutyApiPapi.Data
{
    public enum GameType
    {
        Arena,
        Core,
        Hardcore
    }

    internal static class GameTypeExtensions
    {
        public static string ToKey(this GameType gameType)
        {
            switch (gameType)
            {
                case GameType.Arena:
                    return "arena";
                case GameType.Core:
                    return "core";
                case GameType.Hardcore:
                    return "hc";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameType), gameType, null);
            }
        }
    }
}
