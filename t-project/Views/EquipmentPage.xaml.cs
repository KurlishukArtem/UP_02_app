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

namespace t_project.Views
{
    /// <summary>
    /// Логика взаимодействия для EquipmentPage.xaml
    /// </summary>
    public partial class EquipmentPage : Page
    {
        public DB.Context.EquipContext _equipContext = new DB.Context.EquipContext();
        public EquipmentPage()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            parent.Children.Clear();
            foreach (Models.Equipment _equip in _equipContext.equipment)
            {
                parent.Children.Add(new Elements.Equipment_El(_equip));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Add.EquipmentAdd());
        }
    }
}
