using System.Windows;
using System.Windows.Input;

namespace t_project.Views
{
    /// <summary>
    /// Логика взаимодействия для MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public static MainView main;
        public MainView()
        {
            InitializeComponent();
            main = this;
        }
        #region Оформление.
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Window_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else WindowState = WindowState.Maximized;
        }
        #endregion

        private void Equipment_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new EquipmentPage();
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new InventoryPage();
        }

        private void Audience_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new AudiencePage();
        }

        private void Materials_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new MatrialsPage();
        }

        private void NetSettings_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new NetSettingsPage();    
        }

        private void Programms_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new ProgrammsPage();
        }
    }
}
