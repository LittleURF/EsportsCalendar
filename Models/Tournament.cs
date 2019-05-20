using Newtonsoft.Json;
using System;

namespace EsportsCalendar.Models
{
    public class Tournament
    {
        [JsonProperty("begin_at")]
        public DateTime BeginAt { get; set; }

        [JsonProperty("end_at")]
        public DateTime EndAt { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("league_id")]
        public int LeagueId { get; set; }

        [JsonProperty("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("serie_id")]
        public int SerieId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("winner_id")]
        public int WinnerId { get; set; }

        [JsonProperty("winner_type")]
        public object WinnerType { get; set; }
    }
}