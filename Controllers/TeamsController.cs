using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsportsCalendar.Models;
using EsportsCalendar.Services;
using EsportsCalendar.ViewModels;
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

        private readonly List<Team> teams = new List<Team>();


        public async Task<IActionResult> Index(int? page)
        {
            var teams = new List<Team>();

            var tournamentRequest = new RestRequest("tournaments/upcoming");
            tournamentRequest.AddQueryParameter("per_page", "18");
            var tournaments = await _pandaApi.GetAsync<List<Tournament>>(tournamentRequest);


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
                    teams.Add(team);
                }
            }

            teams.AsQueryable();
            var orderderTeams =  teams.OrderBy(t => t.Name).GroupBy(t => t.Id).Select(t => t.First());
            
            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfTeams = orderderTeams.ToPagedList(pageNumber, 10);
            return View(onePageOfTeams);
        }

        public IActionResult TeamDetails(int teamId)
        {
            var request = new RestRequest("teams/{teamId}");
            request.AddUrlSegment("teamId", teamId);
            var team = _pandaApi.Get<Team>(request).Data;

            return View(team);
        }

        public IActionResult OpponentsDetails(int teamId1, int teamId2)
        {
            var request = new RestRequest("teams/{teamId}");
            request.AddUrlSegment("teamId", teamId1);
            var team1 = _pandaApi.Get<Team>(request).Data;


            var request2 = new RestRequest("teams/{teamId}");
            request2.AddUrlSegment("teamId", teamId2);
            var team2 = _pandaApi.Get<Team>(request2).Data;


            var teams = new List<Team>() { team1, team2 };
            return View(teams);
        }


        // display different route
        public IActionResult SearchTeamByName(TeamSearchModel model)
        {
            string search = model.SearchString;

            foreach (var team in model.Matches)
            {
                if(team.Name.Contains)
            }
            return RedirectToAction("TeamDetails", teamId);
        }
    }
}