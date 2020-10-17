/*
 * Author: Nolan Meyer
 * Class name: PaymentOptions.xaml.cs
 * Purpose: Class used to control the PaymentOptions xaml
 */
using BleakwindBuffet.Data;
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        /// <summary>
        /// Initializes
        /// </summary>
        public PaymentOptions()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Functionality for printing a reciept.
        /// </summary>
        /// <param name="methodString"></param>
        /// <param name="change"></param>
        public void PrintReceipt(string methodString, double change)
        {
            if (DataContext is Order order)
            {
                RecieptPrinter.PrintLine("Order Number: " + order.Number.ToString());
                DateTime now = DateTime.Now;
                RecieptPrinter.PrintLine("Date: " + now.Date.ToString().Substring(0,10) + " " + now.TimeOfDay.ToString().Substring(0, 8));
                RecieptPrinter.PrintLine("");

                foreach (IOrderItem item in order)
                {
                    RecieptPrinter.PrintLine(item.ToString());
                    RecieptPrinter.PrintLine(item.Price.ToString("0.00"));
                    foreach (string str in item.SpecialInstructions)
                    {
                        string s = str;
                        while (s.Length > 40)
                        {
                            RecieptPrinter.PrintLine(s.Substring(0, 40));
                            s = s.Substring(39, s.Length);
                        }
                        RecieptPrinter.PrintLine(s);
                    }
                }
                RecieptPrinter.PrintLine("");
                RecieptPrinter.PrintLine("Subtotal: $" + order.Subtotal.ToString("0.00"));
                RecieptPrinter.PrintLine("Tax: $" + order.Tax.ToString("0.00"));
                RecieptPrinter.PrintLine("Total: $" + order.Total.ToString("0.00"));
                RecieptPrinter.PrintLine("Payment Method: " + methodString);
                if (methodString == "Cash")
                {
                    RecieptPrinter.PrintLine("Change: $" + change.ToString("0.00"));
                }

                RecieptPrinter.CutTape();
                
                MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
                if (parentWindow.DataContext is Order o)
                { 
                    parentWindow.DataContext = new Order();
                    if (this.Parent is Border border) border.Child = new ItemCustomization();
                }
            }
        }

        /// <summary>
        /// Handles a click event on the Cash button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CashButtonClick(object sender, RoutedEventArgs e)
        {
            CashRegisterControl register = new CashRegisterControl(DataContext as Order, this);
            register.Show();
        }

        /// <summary>
        /// Handles a click event on the Credit Button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CreditButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
            if (parentWindow.DataContext is Order order)
            {
                if(CardReader.RunCard(order.Total) == CardTransactionResult.Approved)
                {
                    PrintReceipt("Credit", 0);
                }
                else MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Handles a click event on the Debit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DebitButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
            if (parentWindow.DataContext is Order order)
            {
                if (CardReader.RunCard(order.Total) == CardTransactionResult.Approved)
                {
                    PrintReceipt("Debit", 0);
                }
                else MessageBox.Show("Error");
            }
        }

        /// <summary>
        /// Handles a click on the Return button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ReturnButtonClick(object sender, RoutedEventArgs e)
        {
            if(this.Parent is Border border)
            {
                border.Child = new ItemCustomization();
            }
        }
    }
}
