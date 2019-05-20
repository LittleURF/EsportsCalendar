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

        [JsonProperty("draw")]
        public bool Draw { get; set; }

        [JsonProperty("end_at")]
        public DateTime EndAt { get; set; }

        [JsonProperty("forfeit")]
        public bool Forfeit { get; set; }

        ////[JsonProperty("games")]
        ////public List<Game> Games { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        ////[JsonProperty("league")]
        ////public League League { get; set; }

        ////[JsonProperty("league_id")]
        ////public long LeagueId { get; set; }

        [JsonProperty("live")]
        public Live Live { get; set; }

        [JsonProperty("match_type")]
        public string MatchType { get; set; }

        [JsonProperty("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("number_of_games")]
        public int NumberOfGames { get; set; }

        [JsonProperty("opponents")]
        public List<OpponentElement> Opponents { get; set; }

        [JsonProperty("results")]
        public List<Result> Results { get; set; }

        ////[JsonProperty("serie")]
        ////public Serie Serie { get; set; }

        ////[JsonProperty("serie_id")]
        ////public long SerieId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        ////[JsonProperty("tournament")]
        ////public Tournament Tournament { get; set; }

        ////[JsonProperty("tournament_id")]
        ////public long TournamentId { get; set; }

        [JsonProperty("videogame")]
        public Videogame Videogame { get; set; }

        [JsonProperty("videogame_version")]
        public object VideogameVersion { get; set; }

        [JsonProperty("winner")]
        public object Winner { get; set; }

        [JsonProperty("winner_id")]
        public int WinnerId { get; set; }

    }
}
