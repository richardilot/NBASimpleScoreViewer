using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace NBAScore.Models
{
    public class Teams
    {
        [JsonProperty("data")]
        public List<Team>? data { get; set; }

        //Query, parse and return all teams 
        public static async Task<Teams> GetAllTeamsAsync()
        {
            using var client = new HttpClient();
            var content = await client.GetStringAsync("https://balldontlie.io/api/v1/teams");
            var parsedContent = JsonConvert.DeserializeObject<Teams>(content);
            return parsedContent;
        }
    }
}
