using System;
using System.Collections.Generic;
using System.Text;

namespace t_project.Models
{
    public class NetSettings
    {
        public int id { get; set; }
        public string ip_adress { get; set; }
        public int mask { get; set; }
        public string base_gate { get; set; }
        public string dns_servers { get; set; }

    }
}
