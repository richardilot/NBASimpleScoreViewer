using Newtonsoft.Json;
using System;

namespace NBAScore.Models
{
    public class Game
    {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("date")]
        public DateTime date { get; set; }
        [JsonProperty("home_team")]

        public Team? homeTeam { get; set; }
        [JsonProperty("home_team_score")]
        public int homeTeamScore { get; set; }

        //game status
        public int period { get; set; }
        public bool postSeason { get; set; }
        public int season { get; set; }
        public string? status { get; set; }
        public string? time { get; set; }

        [JsonProperty("visitor_team")]
        public Team? awayTeam { get; set; }
        [JsonProperty("visitor_team_score")]
        public int awayTeamScore { get; set; }

    }
}
