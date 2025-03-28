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
    /// <summary>
    /// Логика взаимодействия для NetSettingsPage.xaml
    /// </summary>
    public partial class NetSettingsPage : Page
    {
        DB.Context.NetSettingsContext _netSettingsContext = new DB.Context.NetSettingsContext();
        public NetSettingsPage()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            parent.Children.Clear();
            foreach (Models.NetSettings _equip in _netSettingsContext.net_settings)
            {
                parent.Children.Add(new Elements.NetSettings_El(_equip));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Add.NetSettingsAdd());
        }
    }
}
