using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC
{
    class LogicLayer
    {
        public EventsDatabase[] GetEvents()
        {
            var db = new EventsDatabaseEntities();
            return db.EventsDatabase.ToArray();
        }
        public EventsDatabase GetEvent(int id)
        {
            var db = new EventsDatabaseEntities();
            return db.EventsDatabase.Find(id);
        }

        public void AddEvents(DateTime date , string time , string thingstodo ,string note, string priority )
        {
            var newEvent= new EventsDatabase();
            newEvent.Date = date;
            newEvent.Time = time;
            newEvent.Things_to_do = thingstodo;
            newEvent.Note = note;
            newEvent.Priority_Level = priority;

            var db = new EventsDatabaseEntities();
            db.EventsDatabase.Add(newEvent);
            db.SaveChanges();
        }

        public void RemoveEvents(int id)
        {
            var db = new EventsDatabaseEntities();
            var @event = db.EventsDatabase.Find(id);

            db.EventsDatabase.Remove(@event);
            db.SaveChanges();

        }

        public void UpdateEvent(int id,DateTime date, string time, string thingstodo,string note, string priority)
        {
            var db = new EventsDatabaseEntities();
            var sukien = db.EventsDatabase.Find(id);

            sukien.Id = id;
            sukien.Date = date;
            sukien.Time = time;
            sukien.Things_to_do = thingstodo;
            sukien.Note = note;
            sukien.Priority_Level = priority;

            db.Entry(sukien).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

        }

        public Lv[] GetLevels()
        {
            var db = new EventsDatabaseEntities();
            return db.Lv.ToArray();
        }
    }

}
