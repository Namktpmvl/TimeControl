//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lv
    {
        public Lv()
        {
            this.EventsDatabase = new HashSet<EventsDatabase>();
        }
    
        public int Id { get; set; }
        public string Level { get; set; }
    
        public virtual ICollection<EventsDatabase> EventsDatabase { get; set; }
    }
}
