using System;
using System.Collections.Generic;
using System.Text;
using MartialArtsClub.Data.Models;
using System.Collections.Generic;


namespace MartialArtsClub.Data.Services
{
    public interface ITimetableDataService
    {
        void Initialise();
        IList<Timetable> SelectAll();
        Timetable SelectByID(int id);
        Timetable Insert(Timetable obj);
        void Update(Timetable obj);
        bool Delete(int id);
    }
}
