/*
 * Author: Nolan Meyer
 * Class name: CustomerQuantity.xaml.cs
 * Purpose: Class used to create a new CustomerQuantity Control
 */
using System;
using System.Collections.Generic;
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
    /// Interaction logic for CustomerQuantity.xaml
    /// </summary>
    public partial class CustomerQuantity : UserControl
    {
        /// <summary>
        /// Dependency Property for the Quantity property
        /// </summary>
        public static DependencyProperty QuantityProperty = DependencyProperty.Register("Quantity", typeof(int), typeof(CustomerQuantity));

        /// <summary>
        /// Repersents the number of currency the customer is giving.
        /// </summary>
        public int Quantity
        {
            get { return (int)GetValue(QuantityProperty); }
            set { SetValue(QuantityProperty, value); }
        }


        /// <summary>
        /// Iniitializes a CustomerQuantity
        /// </summary>
        public CustomerQuantity()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Handles the click of the increment button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void IncrementButtonClick(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Handles the click of the decrement button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void DecrementButtonClick(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}
