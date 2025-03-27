using System;
using System.Windows;
using System.Windows.Controls;

namespace t_project.Views.Add
{
    /// <summary>
    /// Логика взаимодействия для MaterialsAdd.xaml
    /// </summary>
    public partial class MaterialsAdd : Page
    {
        Models.Materials _materialsAdd;
        public MaterialsAdd(Models.Materials materialsAdd)
        {
            InitializeComponent();
            _materialsAdd = materialsAdd;
            if (materialsAdd != null)
            {
                Add.Content = "Изменить";
                tb_material_name.Text = materialsAdd.material_name;
                tb_description.Text = materialsAdd.description;
                tb_come_date.Text = materialsAdd.come_date.ToString();
                tb_picture.Text = materialsAdd.picture.ToString();
                tb_material_number.Text = materialsAdd.material_number.ToString();
            }
            else { Add.Content = "Добавить"; }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainView.main.frame.Navigate(new Views.MainView());
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            DB.Context.MaterialContext _materials = new DB.Context.MaterialContext();

            if (_materialsAdd != null)
            {
                Models.Materials materials = new Models.Materials();
                materials.material_name = tb_material_name.Text;
                materials.description = tb_description.Text;
                materials.come_date = DateTime.Parse(tb_come_date.Text);
                materials.material_number = int.Parse(tb_material_number.Text);
                _materials.materials.Add(materials);
            }
            else
            {

                _materialsAdd.material_name = tb_material_name.Text;
                _materialsAdd.description = tb_description.Text;
                _materialsAdd.come_date = DateTime.Parse(tb_come_date.Text);
                _materialsAdd.material_number = int.Parse(tb_material_number.Text);
                _materials.materials.Add(_materialsAdd);
            }
            _materials.SaveChanges();
            MainView.main.frame.Navigate(new Views.MatrialsPage());
        }
    }
}
