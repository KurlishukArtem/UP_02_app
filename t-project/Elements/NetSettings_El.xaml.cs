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
using t_project.Models;
using t_project.Views;

namespace t_project.Elements
{
    /// <summary>
    /// Логика взаимодействия для NetSettings_El.xaml
    /// </summary>
    public partial class NetSettings_El : UserControl
    {
        Models.NetSettings _netSettings;
        public NetSettings_El(Models.NetSettings netSettings)
        {
            InitializeComponent();
            _netSettings = netSettings;
            this.euip_id.Content += _netSettings.id.ToString();
            this.tb_ip_adress.Content += _netSettings.ip_adress.ToString();
            this.tb_mask.Content += _netSettings.mask.ToString();
            this.tb_base_gate.Content += _netSettings.base_gate.ToString();
            this.tb_dns_servers.Content += _netSettings.dns_servers.ToString();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.Add.NetSettingsAdd(_netSettings));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.NetSettingsContext netSettingsContext = new DB.Context.NetSettingsContext();
            netSettingsContext.net_settings.Remove(_netSettings);
            netSettingsContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.NetSettingsPage());
        }
    }
}
