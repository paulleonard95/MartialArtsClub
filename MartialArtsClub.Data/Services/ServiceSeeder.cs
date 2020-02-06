using System;
using System.Collections.Generic;
using System.Text;
using MartialArtsClub.Data.Models;
using System;

namespace MartialArtsClub.Data.Services
{
    public class ServiceSeeder
    {
        public static void Seed(ITimetableDataService service)
        {
            service.Initialise();

            var c1 = service.Insert(new Timetable
            {
                Day = "Monday",
                ClassType = "Boxing",
                Duration = 60.0,
                Description = "Beginners course for boxing"
            });

            var c2 = service.Insert(new Timetable
            {
                Day = "Tuesday",
                ClassType = "Strength & Conditioning",
                Duration = 60.0,
                Description = "Fast paced class to burn fat and get fit"
            });
        }
    }
}
