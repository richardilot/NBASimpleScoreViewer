using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace NBAScore.Models
{
    public class Games
    {
        [JsonProperty("data")]
        public List<Game>? games { get; set; }

        /**
         * Query, parse and return specific games
         * startDate    : get games after that date
         * endDate      : get games before that date
         * id           : get games from specific team
         **/
        public static async Task<Games> GetGamesAsync(string startDate, string endDate, int id)
        {
            
            using var client = new HttpClient();
            var content = await client.GetStringAsync("https://balldontlie.io/api/v1/games?end_date="+endDate+"&start_date="+startDate+"&team_ids[]="+id);
            var parsedContent = JsonConvert.DeserializeObject<Games>(content);
            return parsedContent;
        }


    }
}
