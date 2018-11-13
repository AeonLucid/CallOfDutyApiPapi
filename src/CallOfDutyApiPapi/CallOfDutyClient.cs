using System;
using System.Threading.Tasks;
using CallOfDutyApiPapi.Data;
using CallOfDutyApiPapi.Responses;
using Flurl;
using Flurl.Http;

namespace CallOfDutyApiPapi
{
    public class CallOfDutyClient : IDisposable
    {
        private const string Endpoint = "https://my.callofduty.com/api/papi-client";

        private readonly FlurlClient _client;

        public CallOfDutyClient()
        {
            _client = new FlurlClient();
        }

        public async Task<Response<Profile>> GetProfileAsync(Title title, Platform platform, string username, ProfileType profileType = ProfileType.Multiplayer)
        {
            return await (Endpoint + "/crm/cod/v2")
                .AppendPathSegment("title").AppendPathSegment(title.ToKey())
                .AppendPathSegment("platform").AppendPathSegment(platform.ToKey())
                .AppendPathSegment("gamer").AppendPathSegment(username, true)
                .AppendPathSegment("profile")
                .SetQueryParam("type", profileType.ToKey())
                .WithClient(_client)
                .GetJsonAsync<Response<Profile>>();
        }

        public async Task<Response<RecentMatches>> GetRecentMatches(Title title, Platform platform, string username, int days = 7)
        {
            return await (Endpoint + "/crm/cod/v2")
                .AppendPathSegment("title").AppendPathSegment(title.ToKey())
                .AppendPathSegment("platform").AppendPathSegment(platform.ToKey())
                .AppendPathSegment("gamer").AppendPathSegment(username, true)
                .AppendPathSegment("matches")
                .AppendPathSegment("days").AppendPathSegment(days)
                .WithClient(_client)
                .GetJsonAsync<Response<RecentMatches>>();
        }

        public void Dispose()
        {
            _client?.Dispose();
        }
    }
}
