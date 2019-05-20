using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsCalendar.Models
{
    public class Match
    {
        [JsonProperty("begin_at")]
        public DateTime BeginAt { get; set; }
        [JsonProperty("videogame")]
        public VideoGame VideoGame { get; set; }
    }
}
