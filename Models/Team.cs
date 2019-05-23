using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportsCalendar.Models
{
    public class Team
    {
        [JsonProperty("acronym")]
        public string Acronym { get; set; }

        [JsonProperty("current_videogame")]
        public Videogame CurrentVideogame { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("players")]
        public List<Player> Players { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}