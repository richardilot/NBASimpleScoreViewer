using Newtonsoft.Json;

namespace NBAScore.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("abbreviation")]
        public string? abbreviation { get; set; }
        [JsonProperty("city")]
        public string? city { get; set; }
        [JsonProperty("conference")]
        public string? conference { get; set; }
        [JsonProperty("division")]
        public string? division { get; set; }
        [JsonProperty("full_name")]
        public string? fullName { get; set; }
        [JsonProperty("name")]
        public string? name { get; set; }
    }
}
