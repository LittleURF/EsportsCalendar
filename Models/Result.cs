using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsCalendar.Models
{
    public class Result
    {
        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("team_id")]
        public int TeamId { get; set; }
    }
}
