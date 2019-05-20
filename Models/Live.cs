using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsCalendar.Models
{
    public class Live
    {
        [JsonProperty("opens_at")]
        public DateTime OpensAt { get; set; }

        [JsonProperty("supported")]
        public bool Supported { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
