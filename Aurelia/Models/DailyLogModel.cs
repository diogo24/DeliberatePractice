using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliberatePracticeAurelia.Models
{
    public class DailyLogModel
    {
        public string Action { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Notes { get; set; }
    }
}
