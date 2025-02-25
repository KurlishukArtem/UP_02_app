using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace t_project.Elements
{
    /// <summary>
    /// Логика взаимодействия для Equipment_El.xaml
    /// </summary>
    public partial class Equipment_El : UserControl
    {
        public Models.Equipment _equipment;
        public Equipment_El(Models.Equipment equipment = null) 
        {
            InitializeComponent();
            _equipment = equipment;
        }
    }
}
