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
    /// Логика взаимодействия для Audience_El.xaml
    /// </summary>
    public partial class AudiencePage : Page
    {
        
        DB.Context.AudienceContext _audienceContext = new DB.Context.AudienceContext();
        public AudiencePage()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            parent.Children.Clear();
            foreach (Models.Audience _equip in _audienceContext.audience)
            {
                parent.Children.Add(new Elements.Audience_El(_equip));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Add.AudienceAdd());
        }
    }
}
