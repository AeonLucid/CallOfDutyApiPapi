using System;

namespace CallOfDutyApiPapi.Data
{
    public enum GameMode
    {
        OneVsOneArena,
        Gridiron,
        Career, // All modes.
        KillConfirmed,
        CaptureTheFlag,
        FreeForAll,
        Domination,
        HardPoint,
        SearchAndDestroy,
        War,
        TeamDeathMatch
    }

    internal static class GameModeExtensions
    {
        public static string ToKey(this GameMode gameMode)
        {
            switch (gameMode)
            {
                case GameMode.OneVsOneArena:
                    return "1v1";
                case GameMode.Gridiron:
                    return "ball";
                case GameMode.Career:
                    return "career";
                case GameMode.KillConfirmed:
                    return "conf";
                case GameMode.CaptureTheFlag:
                    return "ctf";
                case GameMode.FreeForAll:
                    return "dm";
                case GameMode.Domination:
                    return "dom";
                case GameMode.HardPoint:
                    return "hp";
                case GameMode.SearchAndDestroy:
                    return "sd";
                case GameMode.War:
                    return "raid";
                case GameMode.TeamDeathMatch:
                    return "war";
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameMode), gameMode, null);
            }
        }
    }
}
