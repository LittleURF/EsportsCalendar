using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsCalendar.Models
{
    public class Winner
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("type")]
        public object Type { get; set; }
    }
}
