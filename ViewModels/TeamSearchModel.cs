using EsportsCalendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace EsportsCalendar.ViewModels
{
    public class TeamSearchModel
    {
        public List<Team> Teams { get; set; }
        public string SearchString { get; set; }
        public IPagedList<Team> PageOfTeams { get; set; }
    }
}
