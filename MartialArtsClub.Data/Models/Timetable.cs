using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace MartialArtsClub.Data.Models
{
    public class Timetable
    {
        public int Id { get; set; }

        public string Day { get; set; }

        public string ClassType { get; set; }

        public double Duration { get; set; }

        public string Description { get; set; }
    }
}
