using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC
{
    public class EventsView
    {
        public int id { get; set; }

        public DateTime date { get; set; }

        public string time { get; set; }

        public string thingstodo { get; set; }

        public string note { get; set; }

        public string priority { get; set; }


        public EventsView(EventsDatabase evetn)
        {
            this.id = evetn.Id;
            this.date = evetn.Date;
            this.time = evetn.Time;
            this.thingstodo = evetn.Things_to_do;
            this.note = evetn.Note;
            this.priority = evetn.Priority_Level;
        }
    }  
}
