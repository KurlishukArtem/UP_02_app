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
using t_project.Models;
using t_project.Views;

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
            this.euip_id.Content += _equipment.Id.ToString();
            this.tb_invent.Content += _equipment.Type_equip.ToString();
            this.tb_class_id.Content += _equipment.Class_id.ToString();
            this.tb_user.Content += _equipment.Prem_user_id.ToString();
            this.tb_t_user.Content += _equipment.t_Prem_user_id.ToString();
            this.tb_cost.Content += _equipment.cost_eqip_id.ToString();
            this.tb_status.Content += _equipment.Status_id.ToString();
            this.tb_model.Content += _equipment.Model_id.ToString();
            this.tb_comment.Content += _equipment.Comment.ToString();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.Add.EquipmentAdd(_equipment));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.EquipContext equipcontext = new DB.Context.EquipContext();
            equipcontext.equipment.Remove(_equipment);
            equipcontext.SaveChanges();
            MainView.main.frame.Navigate(new Views.EquipmentPage());
        }
    }
}
