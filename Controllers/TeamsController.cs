using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsportsCalendar.Models;
using EsportsCalendar.Services;
using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace EsportsCalendar.Controllers
{
    public class TeamsController : Controller
    {
        private readonly RestClient _pandaApi;

        public TeamsController(IPandaApi pandaApi)
        {
            _pandaApi = pandaApi.GetClient();
        }


        public IActionResult Index()
        {
            var request = new RestRequest("teams");
            request.AddQueryParameter("per_page", "100");
            request.AddQueryParameter("sort", "name");

            var result = _pandaApi.Get<List<Team>>(request);
            var model = result.Data;


            return View(model);
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