/*
 * Author: Nolan Meyer
 * Class name: MainWindow.xaml.cs
 * Purpose: Class used to control the MainWindow xaml
 */
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
using System.Data;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// initializes the main window.
        /// sets the DataContext to the Order.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Order();
        }
    }
}
