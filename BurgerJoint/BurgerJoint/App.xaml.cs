﻿using BurgerJoint.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BurgerJoint
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void logBtn_Click(object sender, RoutedEventArgs e)
        {
            // Adminlog adminlog = new Adminlog();
            // adminlog.ShowDialog();
            Window1 www = new Window1();
            www.ShowDialog();
        }
    }
}