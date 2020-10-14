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

        public PaymentOptions()
        {
            InitializeComponent();
        }


        public void CashButtonClick(object sender, RoutedEventArgs e)
        {
            RegisterViewModel register = new RegisterViewModel();

        }


        public void CreditButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
            if (parentWindow.DataContext is Order order)
            {
                if(CardReader.RunCard(order.Total) == CreditCardTransactionResult.Approved)
                {
                    //string idk = "idk";
                    //RecieptPrinter.PrintLine(idk);
                    //RecieptPrinter.CutTape();
                    parentWindow.DataContext = new Order();
                    if (this.Parent is Border border) border.Child = new ItemCustomization();
                }
                else MessageBox.Show("Error");
            }
        }


        public void DebitButtonClick(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
            if (parentWindow.DataContext is Order order)
            {
                if (CardReader.RunCard(order.Total) == CreditCardTransactionResult.Approved)
                {
                    //RecieptPrinter.PrintLine("idk");
                    //ecieptPrinter.CutTape();
                    parentWindow.DataContext = new Order();
                    if (this.Parent is Border border) border.Child = new ItemCustomization();
                }
                else MessageBox.Show("Error");
            }
        }


        public void ReturnButtonClick(object sender, RoutedEventArgs e)
        {

            if(this.Parent is Border border)
            {
                border.Child = new ItemCustomization();
            }
        }
    }
}
