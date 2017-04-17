using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DeliberatePracticeAurelia.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DeliberatePracticeAurelia.Controllers
{
    [Route("api/[controller]")]
    public class DailyLogsController : Controller
    {
        // GET: /<controller>/
        [HttpGet("[action]")]
        public IEnumerable<DailyLogModel> DailyLogsData()
        {
            return new List<DailyLogModel>() {
                new DailyLogModel { Action = "Action1", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, Notes = "Notes 1" },
                new DailyLogModel { Action = "Action2", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, Notes = "Notes 2" }
            };
        }
    }
}
