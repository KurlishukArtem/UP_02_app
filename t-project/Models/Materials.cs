using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace t_project.Models
{
    public class Materials
    {
        public int id { get; set; }
        public string material_name { get; set; }
        public string description { get; set; }
        public DateTime come_date { get; set; }
        public int material_number { get; set; }

    }
}
