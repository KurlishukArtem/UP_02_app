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
            this.euip_id.Content = _equipment.Id;
            this.tb_invent.Content = _equipment.Type_equip;
            this.tb_class_id.Content = _equipment.Class_id;
            this.tb_user.Content = _equipment.Prem_user_id;
            this.tb_t_user.Content = _equipment.t_Prem_user_id;
            this.tb_cost.Content = _equipment.cost_eqip_id;
            this.tb_status.Content = _equipment.Status_id;
            this.tb_model.Content = _equipment.Model_id;
            this.tb_comment.Content = _equipment.Comment;
        }

    }
}
