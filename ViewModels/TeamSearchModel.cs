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
        public IPagedList<Match> Matches { get; set; }
        public string SearchString { get; set; }
    }
}
