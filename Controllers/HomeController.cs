using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EsportsCalendar.Models;
using EsportsCalendar.Services;
using RestSharp;
using X.PagedList;

/*
 * Make the home page show something different than the matches table, maybe a part of it but also something more
 * Do something at the Teams page, maybe a search box for a team? would that work tho?
 * 
 * Teams page list all teams that take part in the upcoming events
 * So i have to take all upcoming events, and take their players into a list but make sure they do not repeat
 * Then i can either display the whole list or save the list as an array and let users make LINQ Queries to run against it and find their team. Mostly through name.
 * 
 * Both involve making around 10-15 requests to the server, can i change it?
 * 
 * */

namespace EsportsCalendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly RestClient _pandaApi;

        public HomeController(IPandaApi pandaApi)
        {
            _pandaApi = pandaApi.GetClient();
        }



        public IActionResult Index(string game, string timePeriod, int? page)
        {
            var request = new RestRequest("{game}/matches/{timePeriod}");

            // The "game" parameter is defined in the Index View when user clicks
            // to see matches of a specific game, the request gets changed.
            if (!String.IsNullOrWhiteSpace(game))
            {
                request.AddUrlSegment("game", game);
                ViewBag.Game = game;
            }
            else
            {
                request.AddUrlSegment("game", "");
            }

            if (!String.IsNullOrWhiteSpace(timePeriod))
            {
                request.AddUrlSegment("timePeriod", timePeriod);
                ViewBag.TimePeriod = timePeriod;
            }
            else
            {
                request.AddUrlSegment("timePeriod", "upcoming");
            }

            request.AddQueryParameter("per_page", "50");
            var result = _pandaApi.Get<List<Match>>(request);
            var model = result.Data.AsQueryable();


            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfMatches = model.ToPagedList(pageNumber, 6); 
            return View(onePageOfMatches);
        }










        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
