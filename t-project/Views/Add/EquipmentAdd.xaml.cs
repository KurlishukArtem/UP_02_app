using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

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
            if (equipmentAdd != null)
            {
                Add.Content = "Изменить";
                tb_type_equip.Text = equipmentAdd.Type_equip;
                tb_photo.Text = Convert.ToBase64String(equipmentAdd.Photo);
                tb_invent_num.Text = equipmentAdd.Invent_num.ToString();
                tb_class_id.Text = equipmentAdd.Class_id.ToString();
                tb_prem_user_id.Text = equipmentAdd.Prem_user_id.ToString();
                tb_t_prem_user_id.Text = equipmentAdd.t_Prem_user_id.ToString();
                tb_cost_eqip_id.Text = equipmentAdd.t_Prem_user_id.ToString();
                tb_status_id.Text = equipmentAdd.Status_id.ToString();
                tb_model_id.Text = equipmentAdd.Status_id.ToString();
                tb_comment.Text = equipmentAdd.Comment;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.EquipContext equipContext = new DB.Context.EquipContext();

            if (_equipmentAdd == null)
            {
                Models.Equipment equipment = new Models.Equipment();
                equipment.Type_equip = tb_type_equip.Text;
                equipment.Photo = File.ReadAllBytes(tb_photo.Text);
                equipment.Invent_num = int.Parse(tb_invent_num.Text);
                equipment.Class_id = int.Parse(tb_class_id.Text);
                equipment.Prem_user_id = int.Parse(tb_prem_user_id.Text);
                equipment.t_Prem_user_id = int.Parse(tb_t_prem_user_id.Text);
                equipment.cost_eqip_id = int.Parse(tb_cost_eqip_id.Text);
                equipment.Status_id = int.Parse(tb_status_id.Text);
                equipment.Model_id = int.Parse(tb_model_id.Text);
                equipment.Comment = tb_comment.Text;
                equipContext.equipment.Add(equipment);
            }
            else
            {

                _equipmentAdd.Type_equip = tb_type_equip.Text;
                _equipmentAdd.Photo = File.ReadAllBytes(tb_photo.Text);
                _equipmentAdd.Invent_num = int.Parse(tb_invent_num.Text);
                _equipmentAdd.Class_id = int.Parse(tb_class_id.Text);
                _equipmentAdd.Prem_user_id = int.Parse(tb_prem_user_id.Text);
                _equipmentAdd.t_Prem_user_id = int.Parse(tb_t_prem_user_id.Text);
                _equipmentAdd.cost_eqip_id = int.Parse(tb_cost_eqip_id.Text);
                _equipmentAdd.Status_id = int.Parse(tb_status_id.Text);
                _equipmentAdd.Model_id = int.Parse(tb_model_id.Text);
                _equipmentAdd.Comment = tb_comment.Text;
                equipContext.equipment.Update(_equipmentAdd);
            }
            equipContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.EquipmentPage());
        }
    }
}
