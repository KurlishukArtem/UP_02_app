using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace t_project.Elements
{
    
    public partial class Inventory_El : UserControl
    {
        public Models.Inventory _inventory;
        public Inventory_El(Models.Inventory inventory = null)
        {
            InitializeComponent();
            _inventory = inventory;
            this.euip_id.Content += _inventory.id.ToString();
            this.tb_date_start.Content += _inventory.date_start.ToString();
            this.tb_date_end.Content += _inventory.date_end.ToString();
            this.tb_invent_name.Content += _inventory.invent_name.ToString();

        }
    }
}
