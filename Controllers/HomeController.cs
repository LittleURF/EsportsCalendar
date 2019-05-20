using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EsportsCalendar.Models;
using EsportsCalendar.Services;
using RestSharp;


namespace EsportsCalendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestClient _pandaApi;

        public HomeController(IPandaApi pandaApi)
        {
            _pandaApi = pandaApi.GetClient();
        }

        public IActionResult Index(string game)
        {
            var request = new RestRequest("/matches/upcoming");

            // The "game" parameter is defined in the Index View when user clicks
            // to see matches of a specific game, then the request gets changed.
            if (!String.IsNullOrWhiteSpace(game))
            {
                request = new RestRequest("{game}/matches/upcoming");
                request.AddUrlSegment("game", game);
            }


            request.AddQueryParameter("per_page", "8");
            var result = _pandaApi.Get<List<Match>>(request);
            var model = result.Data;
            return View(model);
        }









        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
