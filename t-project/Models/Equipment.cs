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
        public string Photo { get; set; }
        public int Invent_num { get; set; }
        public int Class_id { get; set; }
        public int Prem_user_id { get; set; }
        public int t_Prem_user_id { get; set; }
        public int cost_eqip_id { get; set; }
        public int Status_id { get; set; }
        public int Model_id { get; set; }
        public string Comment { get; set; }
        public Equipment()
        {
            
        }

        public Equipment(int Id, string Type_equip, string Photo, int Invent_num, int Class_id, int Prem_user_id, int t_Prem_user_id, int cost_eqip_id, int Status_id, int Model_id, string Comment)
        {
            this.Id = Id;
            this.Type_equip = Type_equip;
            this.Photo = Photo;
            this.Invent_num = Invent_num;
            this.Class_id = Class_id;
            this.Prem_user_id = Prem_user_id;
            this.t_Prem_user_id = t_Prem_user_id;
            this.cost_eqip_id = cost_eqip_id;
            this.Status_id = Status_id;
            this.Model_id = Model_id;
            this.Comment = Comment;
        }
    }
}
