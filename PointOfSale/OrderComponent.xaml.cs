/*
 * Author: Nolan Meyer
 * Class name: OrderComponent.xaml.cs
 * Purpose: Class used to control the OrderComponent xaml
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {

        /// <summary>
        /// Initializes the order component
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that fires when the remove button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RemoveThisItemClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                order.Remove(orderedItems.SelectedItem as IOrderItem);
            }
        }

        /// <summary>
        /// Event that fires when the selection of items in the order changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnSelectionChanged(object sender, RoutedEventArgs e)
        {
            if (orderedItems.SelectedItem is IOrderItem item)
            {
                item = menuSelectionComponent.editItem(item);
            }
        }
    }
}
