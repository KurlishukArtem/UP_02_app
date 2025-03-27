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

namespace t_project.Views.Add
{
    /// <summary>
    /// Логика взаимодействия для InventoryAdd.xaml
    /// </summary>
    public partial class InventoryAdd : Page
    {
        Models.Inventory _inventoryAdd;
        public InventoryAdd(Models.Inventory inventoryAdd = null)
        {
            InitializeComponent();
            _inventoryAdd = inventoryAdd;
            if (inventoryAdd != null )
            {
                Add.Content = "Изменить";
                tb_date_start.Text = inventoryAdd.date_start.ToString();
                tb_date_end.Text = inventoryAdd.date_end.ToString();
                tb_invent_name.Text = inventoryAdd.invent_name;
            }
            else { Add.Content = "Добавить"; }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.InventContext inventContext = new DB.Context.InventContext();

            if (_inventoryAdd == null)
            {
                Models.Inventory inventory = new Models.Inventory();
                inventory.date_start = DateTime.Parse(tb_date_start.Text);
                inventory.date_end = DateTime.Parse(tb_date_end.Text);
                inventory.invent_name = tb_invent_name.Text;
                inventContext.inventory.Add(inventory);
            }
            else
            {
                _inventoryAdd.date_start = DateTime.Parse(tb_date_start.Text);
                _inventoryAdd.date_end = DateTime.Parse(tb_date_end.Text);
                _inventoryAdd.invent_name = tb_invent_name.Text;
                inventContext.inventory.Update(_inventoryAdd);
            }
            inventContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.InventoryPage());
        }
    }
}
