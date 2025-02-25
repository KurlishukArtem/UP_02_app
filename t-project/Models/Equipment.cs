using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace t_project.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Type_equip { get; set; }
        public Blob Photo { get; set; }
        public int Invent_num { get; set; }
        public int Class_id { get; set; }
        public int Prem_user { get; set; }
        public int t_Prem_user { get; set; }
        public int Cost_equip { get; set; }
        public int Status { get; set; }
        public int Model { get; set; }
        public string Comment { get; set; }
    }
}
