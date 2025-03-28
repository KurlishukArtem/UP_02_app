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
    /// Логика взаимодействия для ProgrammsPage.xaml
    /// </summary>
    public partial class ProgrammsPage : Page
    {
        DB.Context.ProgrammsContext _programmsContext = new DB.Context.ProgrammsContext();
        public ProgrammsPage()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            parent.Children.Clear();
            foreach (Models.Programms _equip in _programmsContext.programms)
            {
                parent.Children.Add(new Elements.Programms_El(_equip));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Add.ProgrammsAdd());
        }
    }
}
