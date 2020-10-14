/*
 * Author: Nolan Meyer
 * Class name: ItemCustomization.xaml.cs
 * Purpose: Class used to control the ItemCustomization xaml
 */
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemCustomization.xaml
    /// </summary>
    public partial class ItemCustomization : UserControl
    {
        public ItemCustomization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the done button in the item customization being clicked
        /// Hides all the customization options
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoneButtonClick(object sender, RoutedEventArgs e)
        {
            bunBox.Visibility = Visibility.Collapsed;
            ketchupBox.Visibility = Visibility.Collapsed;
            mustardBox.Visibility = Visibility.Collapsed;
            pickleBox.Visibility = Visibility.Collapsed;
            cheeseBox.Visibility = Visibility.Collapsed;
            tomatoBox.Visibility = Visibility.Collapsed;
            lettuceBox.Visibility = Visibility.Collapsed;
            mayoBox.Visibility = Visibility.Collapsed;
            baconBox.Visibility = Visibility.Collapsed;
            eggBox.Visibility = Visibility.Collapsed;
            broccoliBox.Visibility = Visibility.Collapsed;
            onionBox.Visibility = Visibility.Collapsed;
            cheddarBox.Visibility = Visibility.Collapsed;
            mushroomBox.Visibility = Visibility.Collapsed;
            sirloinBox.Visibility = Visibility.Collapsed;
            rollBox.Visibility = Visibility.Collapsed;
            sausageBox.Visibility = Visibility.Collapsed;
            hashBrownsBox.Visibility = Visibility.Collapsed;
            pancakesBox.Visibility = Visibility.Collapsed;
            iceBox.Visibility = Visibility.Collapsed;
            lemonBox.Visibility = Visibility.Collapsed;
            creamBox.Visibility = Visibility.Collapsed;
            decafBox.Visibility = Visibility.Collapsed;
            sizeText.Visibility = Visibility.Collapsed;
            sizeMenu.Visibility = Visibility.Collapsed;
            flavorMenu.Visibility = Visibility.Collapsed;
            flavorText.Visibility = Visibility.Collapsed;
            doneButton.Visibility = Visibility.Hidden;
        }
    }
}
