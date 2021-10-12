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
using System.Windows.Threading;

namespace BurgerJoint.UI
{
    /// <summary>
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : Page
    {
        public Order()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(UpdateTimer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
        }
        private void payBtn_Click(object sender, RoutedEventArgs e)
        {
            Checkout checkout = new Checkout();
            NavigationService.GetNavigationService(this).Navigate(checkout);
        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {
            dateText.Text = DateTime.Now.ToString();
        }
    }
}
