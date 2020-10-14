using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : Window
    {
        


        private CurrencyControl hundred;
        public CurrencyControl Hundred
        {
            get => hundred;
            set
            {
                hundred = value;
            }
        }




        public CashRegisterControl()
        {
            InitializeComponent();
        }


        public void ReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        public void FinalizeSaleClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
