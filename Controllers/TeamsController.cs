using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public List<Team> teams = new List<Team>();

        public async Task<IActionResult> Index(int? page)
        {
            var teams = new List<Team>();

            var tournamentRequest = new RestRequest("tournaments/upcoming");
            tournamentRequest.AddQueryParameter("per_page", "18");
            var tournaments = await _pandaApi.GetAsync<List<Tournament>>(tournamentRequest);


            var tasks = new List<Task<List<Team>>>();

            foreach (var tournament in tournaments)
            {
                var teamsRequest = new RestRequest("tournaments/{tournamentId}/teams");
                teamsRequest.AddUrlSegment("tournamentId", tournament.Id.ToString());


                var task =  _pandaApi.GetAsync<List<Team>>(teamsRequest);

                tasks.Add(task);
            }

            var tournamentTeamsList = await Task.WhenAll(tasks);

            foreach (var tournamentTeams in tournamentTeamsList)
            {
                foreach (var team in tournamentTeams)
                {
                    teams.Add(team);
                }
            }


            var orderderTeams = teams.OrderBy(t => t.Name).GroupBy(t => t.Id).Select(t => t.First());


            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfTeams = orderderTeams.ToPagedList(pageNumber, 10);

            var model = new TeamSearchModel() { Teams = orderderTeams.ToList(), PageOfTeams = onePageOfTeams };
            return View(model);
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


        //display different route
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchTeamByName(TeamSearchModel model)
        {
            foreach (var team in model.Teams)
            {
                if (team.Name.ToLower().Contains(model.SearchString.ToLower()))
                {

                    return RedirectToAction(nameof(TeamDetails), new { teamId = team.Id});
                }
                else
                {
                    // This regex removes ' ./_-' characters 
                    string teamNameTrimmed = Regex.Replace(team.Name, "([ .,_-])", String.Empty).ToLower();
                    string searchStringTrimmed = Regex.Replace(model.SearchString, "([ .,_-])", String.Empty).ToLower();

                    if (teamNameTrimmed.Contains(searchStringTrimmed))
                    {
                        return RedirectToAction(nameof(TeamDetails), new { teamId = team.Id });
                    }
                }
            }
            TempData["Error Message"] = "Could not find a team with this name in the database";
            return RedirectToAction(nameof(Index));
        }
    }
}