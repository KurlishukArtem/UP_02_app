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
    /// Логика взаимодействия для AudienceAdd.xaml
    /// </summary>
    public partial class AudienceAdd : Page
    {
        Models.Audience _audiencee { get; set; }

        public AudienceAdd(Models.Audience audiencee = null)
        {
            InitializeComponent();
            _audiencee = audiencee;
            if (audiencee != null)
            {
                Add.Content = "Изменить";
                tb_class_name.Text = audiencee.class_name;
                tb_sub_name.Text = audiencee.sub_name;
                tb_prem_user.Text = audiencee.prem_user.ToString();
                tb_t_prem_user.Text = audiencee.t_prem_user.ToString();
            }
            else { Add.Content = "Добавить"; }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.AudienceContext audienceContext = new DB.Context.AudienceContext();
            
            if (_audiencee == null)
            {
                Models.Audience _audience = new Models.Audience();
                _audience.class_name = tb_class_name.Text;
                _audience.sub_name = tb_sub_name.Text;
                _audience.prem_user = int.Parse(tb_prem_user.Text);
                _audience.t_prem_user = int.Parse(tb_t_prem_user.Text);
                audienceContext.audience.Add(_audience);
            }
            else
            {
                _audiencee.class_name = tb_class_name.Text;
                _audiencee.sub_name = tb_sub_name.Text;
                _audiencee.prem_user = int.Parse(tb_prem_user.Text);
                _audiencee.t_prem_user = int.Parse(tb_t_prem_user.Text);
                audienceContext.audience.Update(_audiencee);
                
            }
            audienceContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.AudiencePage());
        }
    }
}
