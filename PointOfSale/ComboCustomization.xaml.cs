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
    /// Interaction logic for ComboCustomization.xaml
    /// </summary>
    public partial class ComboCustomization : UserControl
    {
        public ComboCustomization()
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
            bunEntreeBox.Visibility = Visibility.Collapsed;
            ketchupEntreeBox.Visibility = Visibility.Collapsed;
            mustardEntreeBox.Visibility = Visibility.Collapsed;
            pickleEntreeBox.Visibility = Visibility.Collapsed;
            cheeseEntreeBox.Visibility = Visibility.Collapsed;
            tomatoEntreeBox.Visibility = Visibility.Collapsed;
            lettuceEntreeBox.Visibility = Visibility.Collapsed;
            mayoEntreeBox.Visibility = Visibility.Collapsed;
            baconEntreeBox.Visibility = Visibility.Collapsed;
            eggEntreeBox.Visibility = Visibility.Collapsed;
            broccoliEntreeBox.Visibility = Visibility.Collapsed;
            onionEntreeBox.Visibility = Visibility.Collapsed;
            cheddarEntreeBox.Visibility = Visibility.Collapsed;
            mushroomEntreeBox.Visibility = Visibility.Collapsed;
            sirloinEntreeBox.Visibility = Visibility.Collapsed;
            rollEntreeBox.Visibility = Visibility.Collapsed;
            sausageEntreeBox.Visibility = Visibility.Collapsed;
            hashBrownsEntreeBox.Visibility = Visibility.Collapsed;
            pancakesEntreeBox.Visibility = Visibility.Collapsed;

           
            sizeSideText.Visibility = Visibility.Collapsed;
            sizeSideMenu.Visibility = Visibility.Collapsed;

            
            iceDrinkBox.Visibility = Visibility.Collapsed;
            lemonDrinkBox.Visibility = Visibility.Collapsed;
            creamDrinkBox.Visibility = Visibility.Collapsed;
            decafDrinkBox.Visibility = Visibility.Collapsed;
            sizeDrinkText.Visibility = Visibility.Collapsed;
            sizeDrinkMenu.Visibility = Visibility.Collapsed;
            flavorDrinkMenu.Visibility = Visibility.Collapsed;
            flavorDrinkText.Visibility = Visibility.Collapsed;


            doneButton.Visibility = Visibility.Hidden;
        }
    }
}
