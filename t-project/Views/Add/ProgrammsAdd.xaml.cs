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
    /// Логика взаимодействия для ProgrammsAdd.xaml
    /// </summary>
    public partial class ProgrammsAdd : Page
    {
        Models.Programms _programms;
        public ProgrammsAdd(Models.Programms programms = null)
        {
            InitializeComponent();
            _programms = programms;
            if (programms != null )
            {
                Add.Content = "Изменить";
                tb_program_name.Text = programms.program_name;
                tb_os_programmer.Text = programms.os_programmer;
                tb_version_os.Text = programms.version_os;
            }
            else { Add.Content = "Добавить"; }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.ProgrammsContext _programmsContext = new DB.Context.ProgrammsContext();  

            if (_programms == null)
            {
                Models.Programms programms = new Models.Programms();
                programms.program_name = tb_program_name.Text;
                programms.os_programmer = tb_os_programmer.Text;
                programms.version_os = tb_version_os.Text;
                _programmsContext.programms.Add( programms );
            }
            else
            {
                _programms.program_name = tb_program_name.Text;
                _programms.os_programmer = tb_os_programmer.Text;
                _programms.version_os = tb_version_os.Text;
                _programmsContext.programms.Update(_programms);
            }
            _programmsContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.ProgrammsPage());
        }
    }
}
