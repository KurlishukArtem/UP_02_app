using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;

namespace t_project.Views.Add
{
    /// <summary>
    /// Логика взаимодействия для EquipmentAdd.xaml
    /// </summary>
    public partial class EquipmentAdd : Page
    {
        Models.Equipment _equipmentAdd;
        public EquipmentAdd(Models.Equipment equipmentAdd = null)
        {
            InitializeComponent();
            _equipmentAdd = equipmentAdd;
            if (equipmentAdd != null)
            {
                Add.Content = "Изменить";
                tb_type_equip.Text = equipmentAdd.type_equip;
                
                tb_invent_num.Text = equipmentAdd.invent_num.ToString();
                tb_class_id.Text = equipmentAdd.class_id.ToString();
                tb_prem_user_id.Text = equipmentAdd.prem_user_id.ToString();
                tb_t_prem_user_id.Text = equipmentAdd.t_prem_user_id.ToString();
                tb_cost_eqip_id.Text = equipmentAdd.t_prem_user_id.ToString();
                tb_status_id.Text = equipmentAdd.status_id.ToString();
                tb_model_id.Text = equipmentAdd.model_id.ToString();
                tb_comment.Text = equipmentAdd.comment;
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
                equipment.type_equip = tb_type_equip.Text;
                //equipment.photo = File.ReadAllBytes(tb_photo.Text);
                equipment.invent_num = int.Parse(tb_invent_num.Text);
                equipment.class_id = int.Parse(tb_class_id.Text);
                equipment.prem_user_id = int.Parse(tb_prem_user_id.Text);
                equipment.t_prem_user_id = int.Parse(tb_t_prem_user_id.Text);
                equipment.cost_eqip_id = int.Parse(tb_cost_eqip_id.Text);
                equipment.status_id = int.Parse(tb_status_id.Text);
                equipment.model_id = int.Parse(tb_model_id.Text);
                equipment.comment = tb_comment.Text;
                equipContext.equipment.Add(equipment);
            }
            else
            {

                _equipmentAdd.type_equip = tb_type_equip.Text;
                //_equipmentAdd.photo = File.ReadAllBytes(tb_photo.Text);
                _equipmentAdd.invent_num = int.Parse(tb_invent_num.Text);
                _equipmentAdd.class_id = int.Parse(tb_class_id.Text);
                _equipmentAdd.prem_user_id = int.Parse(tb_prem_user_id.Text);
                _equipmentAdd.t_prem_user_id = int.Parse(tb_t_prem_user_id.Text);
                _equipmentAdd.cost_eqip_id = int.Parse(tb_cost_eqip_id.Text);
                _equipmentAdd.status_id = int.Parse(tb_status_id.Text);
                _equipmentAdd.model_id = int.Parse(tb_model_id.Text);
                _equipmentAdd.comment = tb_comment.Text;
                equipContext.equipment.Update(_equipmentAdd);
            }
            equipContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.EquipmentPage());
        }

        private void tb_photo_Click(object sender, RoutedEventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"
            };
            if (ofd.ShowDialog() == true)
            {
                try
                {
                    
                    using (var fileStream = File.OpenRead(ofd.FileName))
                    {
                        MemoryStream memoryStream = new MemoryStream();
                        fileStream.CopyTo(memoryStream);
                        _equipmentAdd.photo = memoryStream.ToArray();
                    }
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки фотографии: \n{ex.Message}");
                }
            }
        }
    }
}
