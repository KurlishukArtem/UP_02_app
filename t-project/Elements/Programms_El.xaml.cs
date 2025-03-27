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
    /// Логика взаимодействия для Programms_El.xaml
    /// </summary>
    public partial class Programms_El : UserControl
    {
        Models.Programms _programms;
        public Programms_El(Models.Programms programms)
        {
            InitializeComponent();
            _programms = programms;
            this.euip_id.Content += _programms.id.ToString();
            this.tb_program_name.Content += _programms.program_name.ToString();
            this.tb_os_programmer.Content += _programms.os_programmer.ToString();
            this.tb_version_os.Content += _programms.version_os.ToString();

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.Add.ProgrammsAdd(_programms));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.ProgrammsContext programmContext = new DB.Context.ProgrammsContext();
            programmContext.programms.Remove(_programms);
            programmContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.ProgrammsPage());
        }
    }
}
