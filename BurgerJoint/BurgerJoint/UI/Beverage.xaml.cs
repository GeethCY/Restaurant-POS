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
    /// Interaction logic for Beverage.xaml
    /// </summary>
    public partial class Beverage : Page
    {
        public Beverage()
        {
            InitializeComponent();
        }

        private void slctBtn_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            NavigationService.GetNavigationService(this).Navigate(order);
        }
    }
}
