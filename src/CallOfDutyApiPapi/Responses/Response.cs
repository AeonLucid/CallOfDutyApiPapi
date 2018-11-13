using Newtonsoft.Json;

namespace CallOfDutyApiPapi.Responses
{
    public class Response<T>
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("data")]
        public T Data { get; set; }
    }
}
