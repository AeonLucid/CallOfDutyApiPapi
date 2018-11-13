using System.Threading.Tasks;
using CallOfDutyApiPapi;
using CallOfDutyApiPapi.Data;

namespace ConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            using (var client = new CallOfDutyClient())
            {
                var result = await client.GetProfileAsync(Title.BlackOps4, Platform.BattleNet, "AeonLucid#2662", ProfileType.Zombies);
                var result2 = await client.GetRecentMatches(Title.BlackOps4, Platform.BattleNet, "AeonLucid#2662");
            }
        }
    }
}
