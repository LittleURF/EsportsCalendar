using Newtonsoft.Json;

namespace EsportsCalendar.Models
{
    public class OpponentOpponent
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("hometown")]
        public string Hometown { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }
}