namespace t_project.Models
{
    public class Equipment
    {
        public int id { get; set; }
        public string type_equip { get; set; }
        public byte[] photo { get; set; }
        public int invent_num { get; set; }
        public int class_id { get; set; }
        public int prem_user_id { get; set; }
        public int t_prem_user_id { get; set; }
        public int cost_eqip_id { get; set; }
        public int status_id { get; set; }
        public int model_id { get; set; }
        public string comment { get; set; }
        public Equipment()
        {

        }

     
    }
}
