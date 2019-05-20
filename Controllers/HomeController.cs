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

        public IActionResult Index()
        {
            var request = new RestRequest("lol/matches/upcoming");
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
