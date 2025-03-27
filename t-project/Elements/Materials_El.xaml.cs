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
    /// Логика взаимодействия для Materials_El.xaml
    /// </summary>
    public partial class Materials_El : UserControl
    {
        Models.Materials _materials;
        public Materials_El(Models.Materials materials)
        {
            InitializeComponent();
            _materials = materials;
            this.euip_id.Content += _materials.id.ToString();
            this.tb_material_name.Content += _materials.material_name.ToString();
            this.tb_description.Content += _materials.description.ToString();
            this.tb_come_date.Content += _materials.come_date.ToString();
            this.tb_picture.Content += _materials.picture.ToString();
            this.tb_material_number.Content += _materials.material_number.ToString();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.Add.MaterialsAdd(_materials));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.MaterialContext materialsContext = new DB.Context.MaterialContext();
            materialsContext.materials.Remove(_materials);
            materialsContext.SaveChanges();
            MainView.main.frame.Navigate(new Views.EquipmentPage());
        }
    }
}
