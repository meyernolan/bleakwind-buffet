using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
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
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        /// <summary>
        /// initializes the Menu component
        /// </summary>
        public MenuSelectionComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles a click on the Briarheart Burger button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            var bb = new ItemCustomization();
            bb.bunBox.Visibility = Visibility.Visible;
            bb.ketchupBox.Visibility = Visibility.Visible;
            bb.mustardBox.Visibility = Visibility.Visible;
            bb.pickleBox.Visibility = Visibility.Visible;
            bb.cheeseBox.Visibility = Visibility.Visible;

            bb.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = bb;
        }

        /// <summary>
        /// handles a click on the Double Draugr button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            var dd = new ItemCustomization();
            dd.bunBox.Visibility = Visibility.Visible;
            dd.ketchupBox.Visibility = Visibility.Visible;
            dd.mustardBox.Visibility = Visibility.Visible;
            dd.pickleBox.Visibility = Visibility.Visible;
            dd.cheeseBox.Visibility = Visibility.Visible;
            dd.tomatoBox.Visibility = Visibility.Visible;
            dd.lettuceBox.Visibility = Visibility.Visible;
            dd.mayoBox.Visibility = Visibility.Visible;

            dd.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = dd;
        }

        /// <summary>
        /// handles a click on the Thalmor Triple button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            var tt = new ItemCustomization();
            tt.bunBox.Visibility = Visibility.Visible;
            tt.ketchupBox.Visibility = Visibility.Visible;
            tt.mustardBox.Visibility = Visibility.Visible;
            tt.pickleBox.Visibility = Visibility.Visible;
            tt.cheeseBox.Visibility = Visibility.Visible;
            tt.tomatoBox.Visibility = Visibility.Visible;
            tt.lettuceBox.Visibility = Visibility.Visible;
            tt.mayoBox.Visibility = Visibility.Visible;
            tt.baconBox.Visibility = Visibility.Visible;
            tt.eggBox.Visibility = Visibility.Visible;

            tt.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = tt;
        }

        /// <summary>
        /// handles a click on the Garden Orc Omelette button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            var goo = new ItemCustomization();
            goo.broccoliBox.Visibility = Visibility.Visible;
            goo.mushroomBox.Visibility = Visibility.Visible;
            goo.cheddarBox.Visibility = Visibility.Visible;
            goo.tomatoBox.Visibility = Visibility.Visible;

            goo.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = goo;
        }

        /// <summary>
        /// handles a click on the Philly Poacher button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            var pp = new ItemCustomization();
            pp.sirloinBox.Visibility = Visibility.Visible;
            pp.onionBox.Visibility = Visibility.Visible;
            pp.rollBox.Visibility = Visibility.Visible;

            pp.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = pp;
        }

        /// <summary>
        /// handles a click on the Smokehouse Skeleton button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            var ss = new ItemCustomization();
            ss.eggBox.Visibility = Visibility.Visible;
            ss.hashBrownsBox.Visibility = Visibility.Visible;
            ss.pancakesBox.Visibility = Visibility.Visible;
            ss.sausageBox.Visibility = Visibility.Visible;

            ss.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ss;
        }

        /// <summary>
        /// handles a click on the Thugs TBone button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            var ttb = new ItemCustomization();

            ttb.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ttb;
        }

        /// <summary>
        /// handles a click on the Dragonborn Waffle Fries button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            var dwf = new ItemCustomization();
            dwf.sizeText.Visibility = Visibility.Visible;
            dwf.sizeMenu.Visibility = Visibility.Visible;

            dwf.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = dwf;
        }

        /// <summary>
        /// handles a click on the Fried Miraak button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            var fm = new ItemCustomization();
            fm.sizeText.Visibility = Visibility.Visible;
            fm.sizeMenu.Visibility = Visibility.Visible;

            fm.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = fm;
        }

        /// <summary>
        /// handles a click on the Mad Otar Grits button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            var mog = new ItemCustomization();
            mog.sizeText.Visibility = Visibility.Visible;
            mog.sizeMenu.Visibility = Visibility.Visible;

            mog.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = mog;
        }

        /// <summary>
        /// handles a click on the Vokun Salad button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            var vs = new ItemCustomization();
            vs.sizeText.Visibility = Visibility.Visible;
            vs.sizeMenu.Visibility = Visibility.Visible;

            vs.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = vs;
        }

        /// <summary>
        /// handles a click on the Aretino Apple Juice button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            var aaj = new ItemCustomization();
            aaj.sizeText.Visibility = Visibility.Visible;
            aaj.sizeMenu.Visibility = Visibility.Visible;

            aaj.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = aaj;
        }

        /// <summary>
        /// handles a click on the Candlehearth Coffee button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            var cc = new ItemCustomization();
            cc.sizeText.Visibility = Visibility.Visible;
            cc.sizeMenu.Visibility = Visibility.Visible;

            cc.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = cc;
        }

        /// <summary>
        /// handles a click on the Markarth Milk button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            var mm = new ItemCustomization();
            mm.sizeText.Visibility = Visibility.Visible;
            mm.sizeMenu.Visibility = Visibility.Visible;

            mm.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = mm;
        }

        /// <summary>
        /// handles a click on the Sailor Soda button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            var ss = new ItemCustomization();
            ss.sizeText.Visibility = Visibility.Visible;
            ss.sizeMenu.Visibility = Visibility.Visible;
            ss.flavorText.Visibility = Visibility.Visible;
            ss.flavorMenu.Visibility = Visibility.Visible;

            ss.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ss;
        }

        /// <summary>
        /// handles a click on the Warrior Water button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            var ww = new ItemCustomization();
            ww.sizeText.Visibility = Visibility.Visible;
            ww.sizeMenu.Visibility = Visibility.Visible;

            ww.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ww;
        }
    }
}
