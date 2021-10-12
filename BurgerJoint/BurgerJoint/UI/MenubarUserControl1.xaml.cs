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

namespace BurgerJoint.UI
{
    /// <summary>
    /// Interaction logic for MenubarUserControl1.xaml
    /// </summary>
    public partial class MenubarUserControl1 : UserControl
    {
        public MenubarUserControl1()
        {
            InitializeComponent();
        }

        private void Home_Click_1(object sender, RoutedEventArgs e)
        {
            Welcome home = new Welcome();
            NavigationService.GetNavigationService(this).Navigate(home);
        }

        private void Burger_Click_1(object sender, RoutedEventArgs e)
        {
            Burger burger = new Burger();
            NavigationService.GetNavigationService(this).Navigate(burger);
        }

        private void Beverage_Click_1(object sender, RoutedEventArgs e)
        {
            Beverage beverage = new Beverage();
            NavigationService.GetNavigationService(this).Navigate(beverage);
        }

        private void About_Click_1(object sender, RoutedEventArgs e)
        {
            About about = new About();
            NavigationService.GetNavigationService(this).Navigate(about);
        }

        private void Exit_Click_1(object sender, RoutedEventArgs e)
        {
            Home window = Application.Current.MainWindow as Home;
            window.Close();
        }

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            Side side = new UI.Side();
            NavigationService.GetNavigationService(this).Navigate(side);
        }
    }
}
