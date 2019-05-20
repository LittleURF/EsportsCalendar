using Newtonsoft.Json;

namespace EsportsCalendar.Models
{
    public class OpponentElement
    {
        [JsonProperty("opponent")]
        public OpponentOpponent Opponent { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}