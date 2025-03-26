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
using t_project.DB.Context;

namespace t_project.Views
{
    public partial class InventoryPage : Page
    {
        public DB.Context.InventContext _inventContext = new DB.Context.InventContext();
        public InventoryPage()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            parent.Children.Clear();
            foreach (Models.Inventory _equip in _inventContext.inventory)
            {
                parent.Children.Add(new Elements.Inventory_El(_equip));
            }
        }
    }
}
