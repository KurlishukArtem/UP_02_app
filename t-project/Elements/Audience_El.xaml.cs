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

namespace t_project.Elements
{
    /// <summary>
    /// Логика взаимодействия для Audience_El.xaml
    /// </summary>
    public partial class Audience_El : UserControl
    {
        public Models.Audience _audience;
        public Audience_El(Models.Audience audience = null)
        {
            InitializeComponent();
            _audience = audience;
            this.audi_id.Content += _audience.Id.ToString();
            this.tb_class_name.Content += _audience.class_name.ToString();
            this.tb_sub_name.Content += _audience.sub_name.ToString();
            this.tb_prem_user.Content += _audience.prem_user.ToString();
            this.tb_t_prem_user.Content += _audience.t_prem_user.ToString();
        }
        
    }
}
