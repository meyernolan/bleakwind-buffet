/*
 * Author: Nolan Meyer
 * Class name: CashRegister.xaml.cs
 * Purpose: Class used to control the View of the  Cash Register
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : Window
    {
        /// <summary>
        /// Holds the PaymentOptions class we came from.
        /// </summary>
        PaymentOptions payment;

        /// <summary>
        /// Constructor for the CashRegisterControl class. 
        /// Initializes by creating a new RegisterViewModel.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="p"></param>
        public CashRegisterControl(Order o, PaymentOptions p)
        {
            InitializeComponent();
            payment = p;
            var gvm = new RegisterViewModel(o);
            DataContext = gvm;
        }

        /// <summary>
        /// Handles a click on the Return to Order button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnToOrderClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles a click on the Finalize Sale Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FinalizeSaleClick(object sender, RoutedEventArgs e)
        {
            (DataContext as RegisterViewModel).CashOut();
            payment.PrintReceipt("Cash", (DataContext as RegisterViewModel).ChangeTotal);
            this.Close();
        }

    }
}
