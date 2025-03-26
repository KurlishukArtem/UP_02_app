using System;
using System.Collections.Generic;
using System.Text;

namespace t_project.Models
{
    public class Inventory
    {
        public int id { get; set; }
        public string invent_name { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_end { get; set; }

    }
}
