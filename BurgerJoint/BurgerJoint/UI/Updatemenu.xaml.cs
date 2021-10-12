using BurgerJoint.Database;
using BurgerJoint.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Updatemenu.xaml
    /// </summary>
    public partial class Updatemenu : Page

      
    {
        private ObservableCollection<Item> item;


        DatabaseRepository repository = new DatabaseRepository();
        public Updatemenu()
        {
            InitializeComponent();
        }
    }
}
