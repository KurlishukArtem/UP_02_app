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

namespace t_project.Views.Add
{
    /// <summary>
    /// Логика взаимодействия для EquipmentAdd.xaml
    /// </summary>
    public partial class EquipmentAdd : Page
    {
        Models.Equipment _equipmentAdd;
        public EquipmentAdd(Models.Equipment equipmentAdd)
        {
            InitializeComponent();
            _equipmentAdd = equipmentAdd;
            if (equipmentAdd != null )
            {
                Add.Content = "Изменить";
                tb_type_equip.Text = equipmentAdd.Type_equip;
                tb_photo.Text = equipmentAdd.Photo;
                tb_invent_num.Text = equipmentAdd.Invent_num.ToString();
                tb_class_id.Text = equipmentAdd.Class_id.ToString();
                tb_prem_user_id.Text = equipmentAdd.Prem_user_id.ToString();
                tb_t_prem_user_id.Text = equipmentAdd.t_Prem_user_id.ToString();
                tb_cost_eqip_id.Text = equipmentAdd.t_Prem_user_id.ToString();
                tb_status_id.Text = equipmentAdd.Status_id.ToString();
                tb_model_id.Text = equipmentAdd.Status_id.ToString() ;
                tb_comment.Text = equipmentAdd.Comment;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
