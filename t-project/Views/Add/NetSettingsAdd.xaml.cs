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

namespace t_project.Views.Add
{
    /// <summary>
    /// Логика взаимодействия для NetSettingsAdd.xaml
    /// </summary>
    public partial class NetSettingsAdd : Page
    {
        Models.NetSettings _netSettings;
        public NetSettingsAdd(Models.NetSettings netSettings = null)
        {
            InitializeComponent();
            _netSettings = netSettings;
            if (netSettings != null)
            {
                Add.Content = "Изменить";
                tb_ip_adress.Text = netSettings.ip_adress;
                tb_mask.Text = netSettings.mask.ToString();
                tb_base_gate.Text = netSettings.base_gate;
                tb_dns_servers.Text = netSettings.dns_servers;
            }
            else { Add.Content = "Добавить"; }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.NetSettingsContext netSettingsContext = new DB.Context.NetSettingsContext();

            if (_netSettings == null)
            {
                Models.NetSettings netSettings = new Models.NetSettings();
                netSettings.ip_adress = tb_ip_adress.Text.ToString();
                netSettings.mask = int.Parse(tb_mask.Text);
                netSettings.base_gate = tb_base_gate.Text.ToString();
                netSettings.dns_servers = tb_dns_servers.Text.ToString();
                netSettingsContext.net_settings.Add(netSettings);
            }
            else
            {
                _netSettings.ip_adress = tb_ip_adress.Text.ToString();
                _netSettings.mask = int.Parse(tb_mask.Text);
                _netSettings.base_gate = tb_base_gate.Text.ToString();
                _netSettings.dns_servers = tb_dns_servers.Text.ToString();
                netSettingsContext.net_settings.Update(_netSettings);
            }
            netSettingsContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.NetSettingsPage()); 
        }
    }
}
