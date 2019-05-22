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
    public class TournamentsController : Controller
    {
        private readonly RestClient _pandaApi;

        public TournamentsController(IPandaApi pandaApi)
        {
            _pandaApi = pandaApi.GetClient();
        }


        public IActionResult Index(int? page)
        {
            var request = new RestRequest("series/upcoming");
            request.AddQueryParameter("per_page", "18");
            var result = _pandaApi.Get<List<Serie>>(request);
            var model = result.Data.AsQueryable();

            var pageNumber = page ?? 1; // if no page was specified in the querystring, default to the first page (1)
            var onePageOfMatches = model.ToPagedList(pageNumber, 6);

            return View(onePageOfMatches);
        }
    }
}