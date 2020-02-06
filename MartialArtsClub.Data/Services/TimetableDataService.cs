using System;
using System.Collections.Generic;
using System.Text;
using MartialArtsClub.Data.Models;
using MartialArtsClub.Data.Respository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace MartialArtsClub.Data.Services
{
    public class TimetableDataService : ITimetableDataService
    {
        private TimetableDBContext db = null;

        public TimetableDataService()
        {
            this.db = new TimetableDBContext();
        }
        public bool Delete(int id)
        {
            var existing = db.Classes.FirstOrDefault(c => c.Id == id);
            if (existing == null)
            {
                return false;
            }
            db.Remove(existing);
            db.SaveChanges();
            return true;
        }

        public void Initialise()
        {
            db.Initialise();
        }

        public Timetable Insert(Timetable obj)
        {
            db.Classes.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public IList<Timetable> SelectAll()
        {
            return db.Classes.OrderBy(a => a.Day).ToList();
        }

        public Timetable SelectByID(int id)
        {
            return db.Classes.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Timetable obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
