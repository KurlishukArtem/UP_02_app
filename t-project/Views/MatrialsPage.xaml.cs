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
    /// Логика взаимодействия для MatrialsPage.xaml
    /// </summary>
    public partial class MatrialsPage : Page
    {
        DB.Context.MaterialContext _materialContext = new DB.Context.MaterialContext();
        public MatrialsPage()
        {
            InitializeComponent();
            LoadItem();
        }
        public void LoadItem()
        {
            parent.Children.Clear();
            foreach (Models.Materials _equip in _materialContext.materials)
            {
                parent.Children.Add(new Elements.Materials_El(_equip));
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Add.MaterialsAdd());
        }
    }
}
