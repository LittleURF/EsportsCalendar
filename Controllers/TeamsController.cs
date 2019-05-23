using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsportsCalendar.Models;
using EsportsCalendar.Services;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using X.PagedList;

namespace EsportsCalendar.Controllers
{
    public class TeamsController : Controller
    {
        private readonly RestClient _pandaApi;

        public TeamsController(IPandaApi pandaApi)
        {
            _pandaApi = pandaApi.GetClient();
        }


        public async Task<IActionResult> Index(int? page)
        {
            var teams = new List<Team>();

            var tournamentRequest = new RestRequest("tournaments/upcoming");
            tournamentRequest.AddQueryParameter("per_page", "18");
            var tournaments =  await _pandaApi.GetAsync<List<Tournament>>(tournamentRequest);


            //var teamsRequest = new RestRequest("tournaments/2349/teams");
            //teamsRequest.AddQueryParameter("tournamentId", "2349");
            //var tournamentTeams = await _pandaApi.GetAsync<List<object>>(teamsRequest);



            foreach (var tournament in tournaments)
            {
                var teamsRequest = new RestRequest("tournaments/{tournamentId}/teams");
                teamsRequest.AddUrlSegment("tournamentId", tournament.Id.ToString());
                var tournamentTeams = await _pandaApi.GetAsync<List<Team>>(teamsRequest);


                foreach (var team in tournamentTeams)
                {
                    if (teams.Contains(team)) { }
                    else
                    {
                        teams.Add(team);
                    }

                }
            }

            teams.AsQueryable();

            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfTeams = teams.ToPagedList(pageNumber, 10);
            return View(onePageOfTeams);
        }

        public IActionResult TeamDetails(int teamId)
        {
            var request = new RestRequest("teams/{teamId}");
            request.AddUrlSegment("teamId", teamId);
            var team1 = _pandaApi.Get<Team>(request).Data;
        }

        public IActionResult OpponentsDetails(int teamId1, int teamId2)
        {
            var request = new RestRequest("teams/{teamId}");
            request.AddUrlSegment("teamId", teamId1);
            var team1 = _pandaApi.Get<Team>(request).Data;

            var team2 = _pandaApi.Get<Team>(new RestRequest("teams/{teamId}").AddUrlSegment("teamId", teamId2)).Data;

            var teams = new List<Team>() { team1, team2 };
            return View(teams);
        }
    }
}