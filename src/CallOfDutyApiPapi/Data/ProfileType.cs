using System;

namespace CallOfDutyApiPapi.Data
{
    public enum ProfileType
    {
        Multiplayer,
        Blackout,
        Zombies
    }

    internal static class ProfileTypeExtensions
    {
        public static string ToKey(this ProfileType profileType)
        {
            switch (profileType)
            {
                case ProfileType.Multiplayer:
                    return "mp";
                case ProfileType.Blackout:
                    return "blackout";
                case ProfileType.Zombies:
                    return "zombies";
                default:
                    throw new ArgumentOutOfRangeException(nameof(profileType), profileType, null);
            }
        }
    }
}
