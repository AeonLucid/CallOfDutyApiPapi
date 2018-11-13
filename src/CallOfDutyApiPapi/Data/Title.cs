using System;

namespace CallOfDutyApiPapi.Data
{
    public enum Title
    {
        BlackOps3,
        BlackOps4,
        InfiniteWarfare,
        WorldWar2
    }

    internal static class TitleExtensions
    {
        public static string ToKey(this Title title)
        {
            switch (title)
            {
                case Title.BlackOps3:
                    return "bo3";
                case Title.BlackOps4:
                    return "bo4";
                case Title.InfiniteWarfare:
                    return "iw";
                case Title.WorldWar2:
                    return "wwii";
                default:
                    throw new ArgumentOutOfRangeException(nameof(title), title, null);
            }
        }
    }
}
