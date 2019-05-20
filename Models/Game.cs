using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsCalendar.Models
{
    public class Game
    {
        [JsonProperty("begin_at")]
        public DateTime BeginAt { get; set; }

        [JsonProperty("end_at")]
        public DateTime EndAt { get; set; }

        [JsonProperty("finished")]
        public bool Finished { get; set; }

        [JsonProperty("forfeit")]
        public bool Forfeit { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("length")]
        public TimeSpan Length { get; set; }

        [JsonProperty("match_id")]
        public int MatchId { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("winner")]
        public Winner Winner { get; set; }

        [JsonProperty("winner_type")]
        public object WinnerType { get; set; }

    }
}
