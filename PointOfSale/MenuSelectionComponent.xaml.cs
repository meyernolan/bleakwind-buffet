/*
 * Author: Nolan Meyer
 * Class name: MenuSelectionComponent.xaml.cs
 * Purpose: Class used to control the MenuSelectionComponent xaml
 */
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
            var initialize = new ItemCustomization();
            itemBorder.Child = initialize;
        }

        /// <summary>
        /// Handles a click on the Briarheart Burger button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BriarheartBurgerClick(object sender, RoutedEventArgs e)
        {
            BriarheartBurger briarheart = new BriarheartBurger();
            var bb = new ItemCustomization();
            bb.DataContext = briarheart;
            bb.itemName.Text = "Briarheart Burger";
            bb.bunBox.Visibility = Visibility.Visible;
            bb.ketchupBox.Visibility = Visibility.Visible;
            bb.mustardBox.Visibility = Visibility.Visible;
            bb.pickleBox.Visibility = Visibility.Visible;
            bb.cheeseBox.Visibility = Visibility.Visible;

            bb.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = bb;
            if (DataContext is Order order)
            {
                order.Add(briarheart);
            }
        }

        /// <summary>
        /// handles a click on the Double Draugr button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DoubleDraugrClick(object sender, RoutedEventArgs e)
        {
            DoubleDraugr doubleD = new DoubleDraugr();
            var dd = new ItemCustomization();
            dd.DataContext = doubleD;
            dd.itemName.Text = "Double Draugr";
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
            if (DataContext is Order order)
            {
                order.Add(doubleD);
            }
        }

        /// <summary>
        /// handles a click on the Thalmor Triple button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ThalmorTripleClick(object sender, RoutedEventArgs e)
        {
            ThalmorTriple thalmor = new ThalmorTriple();
            var tt = new ItemCustomization();
            tt.DataContext = thalmor;
            tt.itemName.Text = "Thalmor Triple";
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
            if(DataContext is Order order)
            {
                order.Add(thalmor);
            }
        }

        /// <summary>
        /// handles a click on the Garden Orc Omelette button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void GardenOrcOmeletteClick(object sender, RoutedEventArgs e)
        {
            GardenOrcOmelette gardenOrc = new GardenOrcOmelette();
            var goo = new ItemCustomization();
            goo.DataContext = gardenOrc;
            goo.itemName.Text = "Garden Orc Omelette";
            goo.broccoliBox.Visibility = Visibility.Visible;
            goo.mushroomBox.Visibility = Visibility.Visible;
            goo.cheddarBox.Visibility = Visibility.Visible;
            goo.tomatoBox.Visibility = Visibility.Visible;

            goo.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = goo;
            if (DataContext is Order order)
            {
                order.Add(gardenOrc);
            }
        }

        /// <summary>
        /// handles a click on the Philly Poacher button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void PhillyPoacherClick(object sender, RoutedEventArgs e)
        {
            PhillyPoacher philly = new PhillyPoacher();
            var pp = new ItemCustomization();
            pp.DataContext = philly;
            pp.itemName.Text = "Philly Poacher";
            pp.sirloinBox.Visibility = Visibility.Visible;
            pp.onionBox.Visibility = Visibility.Visible;
            pp.rollBox.Visibility = Visibility.Visible;

            pp.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = pp;
            if (DataContext is Order order)
            {
                order.Add(philly);
            }
        }

        /// <summary>
        /// handles a click on the Smokehouse Skeleton button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SmokehouseSkeletonClick(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton smokehouse = new SmokehouseSkeleton();
            var ss = new ItemCustomization();
            ss.itemName.Text = "Smokehouse Skeleton";
            ss.DataContext = smokehouse;
            ss.eggBox.Visibility = Visibility.Visible;
            ss.hashBrownsBox.Visibility = Visibility.Visible;
            ss.pancakesBox.Visibility = Visibility.Visible;
            ss.sausageBox.Visibility = Visibility.Visible;

            ss.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ss;
            if (DataContext is Order order)
            {
                order.Add(smokehouse);
            }
        }

        /// <summary>
        /// handles a click on the Thugs TBone button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ThugsTBoneClick(object sender, RoutedEventArgs e)
        {
            ThugsTBone thugs = new ThugsTBone();
            var ttb = new ItemCustomization();
            ttb.DataContext = thugs;
            ttb.itemName.Text = "Thugs T-Bone";

            ttb.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ttb;
            if (DataContext is Order order)
            {
                order.Add(thugs);
            }
        }

        /// <summary>
        /// handles a click on the Dragonborn Waffle Fries button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DragonbornWaffleFriesClick(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries dragonborn = new DragonbornWaffleFries();
            var dwf = new ItemCustomization();
            dwf.DataContext = dragonborn;
            dwf.itemName.Text = "Dragonborn Waffle Fries";
            dwf.sizeText.Visibility = Visibility.Visible;
            dwf.sizeMenu.Visibility = Visibility.Visible;

            dwf.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = dwf; 
            if (DataContext is Order order)
            {
                order.Add(dragonborn);
            }
        }

        /// <summary>
        /// handles a click on the Fried Miraak button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void FriedMiraakClick(object sender, RoutedEventArgs e)
        {
            FriedMiraak fried = new FriedMiraak();
            var fm = new ItemCustomization();
            fm.DataContext = fried;
            fm.itemName.Text = "Fried Miraak";
            fm.sizeText.Visibility = Visibility.Visible;
            fm.sizeMenu.Visibility = Visibility.Visible;

            fm.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = fm;
            if (DataContext is Order order)
            {
                order.Add(fried);
            }
        }

        /// <summary>
        /// handles a click on the Mad Otar Grits button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MadOtarGritsClick(object sender, RoutedEventArgs e)
        {
            MadOtarGrits mad = new MadOtarGrits();
            var mog = new ItemCustomization();
            mog.DataContext = mad;
            mog.itemName.Text = "Mad Otar Grits";
            mog.sizeText.Visibility = Visibility.Visible;
            mog.sizeMenu.Visibility = Visibility.Visible;

            mog.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = mog;
            if (DataContext is Order order)
            {
                order.Add(mad);
            }
        }

        /// <summary>
        /// handles a click on the Vokun Salad button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VokunSaladClick(object sender, RoutedEventArgs e)
        {
            VokunSalad vokun = new VokunSalad();
            var vs = new ItemCustomization();
            vs.DataContext = vokun;
            vs.itemName.Text = "Vokun Salad";
            vs.sizeText.Visibility = Visibility.Visible;
            vs.sizeMenu.Visibility = Visibility.Visible;

            vs.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = vs;
            if (DataContext is Order order)
            {
                order.Add(vokun);
            }
        }

        /// <summary>
        /// handles a click on the Aretino Apple Juice button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void AretinoAppleJuiceClick(object sender, RoutedEventArgs e)
        {
            AretinoAppleJuice aretino = new AretinoAppleJuice();
            var aaj = new ItemCustomization();
            aaj.DataContext = aretino;
            aaj.itemName.Text = "Aretino Apple Juice";
            aaj.sizeText.Visibility = Visibility.Visible;
            aaj.sizeMenu.Visibility = Visibility.Visible;
            aaj.iceBox.Visibility = Visibility.Visible;

            aaj.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = aaj;
            if (DataContext is Order order)
            {
                order.Add(aretino);
            }
        }

        /// <summary>
        /// handles a click on the Candlehearth Coffee button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void CandlehearthCoffeeClick(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee candlehearth = new CandlehearthCoffee();
            var cc = new ItemCustomization();
            cc.DataContext = candlehearth;
            cc.itemName.Text = "Candlehearth Coffee";
            cc.sizeText.Visibility = Visibility.Visible;
            cc.sizeMenu.Visibility = Visibility.Visible;
            cc.iceBox.Visibility = Visibility.Visible;

            cc.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = cc;
            if (DataContext is Order order)
            {
                order.Add(candlehearth);
            }
        }

        /// <summary>
        /// handles a click on the Markarth Milk button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MarkarthMilkClick(object sender, RoutedEventArgs e)
        {
            MarkarthMilk markarth = new MarkarthMilk();
            var mm = new ItemCustomization();
            mm.DataContext = markarth;
            mm.itemName.Text = "Markarth Milk";
            mm.sizeText.Visibility = Visibility.Visible;
            mm.sizeMenu.Visibility = Visibility.Visible;
            mm.iceBox.Visibility = Visibility.Visible;

            mm.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = mm;
            if (DataContext is Order order)
            {
                order.Add(markarth);
            }
        }

        /// <summary>
        /// handles a click on the Sailor Soda button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SailorSodaClick(object sender, RoutedEventArgs e)
        {
            SailorSoda sailor = new SailorSoda();
            var ss = new ItemCustomization();
            ss.DataContext = sailor;
            ss.itemName.Text = "Sailor Soda";
            ss.sizeText.Visibility = Visibility.Visible;
            ss.sizeMenu.Visibility = Visibility.Visible;
            ss.flavorText.Visibility = Visibility.Visible;
            ss.flavorMenu.Visibility = Visibility.Visible;
            ss.iceBox.Visibility = Visibility.Visible;

            ss.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ss;
            if (DataContext is Order order)
            {
                order.Add(sailor);
            }
        }

        /// <summary>
        /// handles a click on the Warrior Water button
        /// Shows all the options available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void WarriorWaterClick(object sender, RoutedEventArgs e)
        {
            WarriorWater warrior = new WarriorWater();
            var ww = new ItemCustomization();
            ww.DataContext = warrior;
            ww.itemName.Text = "Warrior Water";
            ww.sizeText.Visibility = Visibility.Visible;
            ww.sizeMenu.Visibility = Visibility.Visible;
            ww.iceBox.Visibility = Visibility.Visible;
            ww.lemonBox.Visibility = Visibility.Visible;

            ww.doneButton.Visibility = Visibility.Visible;
            itemBorder.Child = ww;
            if (DataContext is Order order)
            {
                order.Add(warrior);
            }
        }


        public void DoneWithOrderClick(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
            /*if(parentWindow.DataContext is Order order)
            {
                order.Clear();
            }*/
            parentWindow.DataContext = new Order();
        }


        public void CancelOrderClick(object sender, RoutedEventArgs e)
        {
            MainWindow parentWindow = (MainWindow)MainWindow.GetWindow(this);
            /*if(parentWindow.DataContext is Order order)
            {
                order.Clear();
            }*/
            parentWindow.DataContext = new Order();
        }


        /// <summary>
        /// method for switching edit screens when an item already in the order is selsected.
        /// </summary>
        /// <param name="item"> The item whose sceen is to be shown.</param>
        /// <returns>the item</returns>
        public IOrderItem editItem(IOrderItem item)
        {
            if(item is BriarheartBurger briarheart)
            {
                var bb = new ItemCustomization();
                bb.DataContext = briarheart;
                bb.itemName.Text = "Briarheart Burger";
                bb.bunBox.Visibility = Visibility.Visible;
                bb.ketchupBox.Visibility = Visibility.Visible;
                bb.mustardBox.Visibility = Visibility.Visible;
                bb.pickleBox.Visibility = Visibility.Visible;
                bb.cheeseBox.Visibility = Visibility.Visible;

                bb.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = bb;
            }
            else if(item is DoubleDraugr doubleD)
            {
                var dd = new ItemCustomization();
                dd.DataContext = doubleD;
                dd.itemName.Text = "Double Draugr";
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
            else if(item is ThalmorTriple thalmor)
            {
                var tt = new ItemCustomization();
                tt.DataContext = thalmor;
                tt.itemName.Text = "Thalmor Triple";
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
            else if(item is GardenOrcOmelette garden)
            {
                var goo = new ItemCustomization();
                goo.DataContext = garden;
                goo.itemName.Text = "Garden Orc Omelette";
                goo.broccoliBox.Visibility = Visibility.Visible;
                goo.mushroomBox.Visibility = Visibility.Visible;
                goo.cheddarBox.Visibility = Visibility.Visible;
                goo.tomatoBox.Visibility = Visibility.Visible;

                goo.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = goo;
            }
            else if(item is SmokehouseSkeleton smokehouse)
            {
                var ss = new ItemCustomization();
                ss.itemName.Text = "Smokehouse Skeleton";
                ss.DataContext = smokehouse;
                ss.eggBox.Visibility = Visibility.Visible;
                ss.hashBrownsBox.Visibility = Visibility.Visible;
                ss.pancakesBox.Visibility = Visibility.Visible;
                ss.sausageBox.Visibility = Visibility.Visible;

                ss.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = ss;
            }
            else if (item is PhillyPoacher philly)
            {
                var pp = new ItemCustomization();
                pp.DataContext = philly;
                pp.itemName.Text = "Philly Poacher";
                pp.sirloinBox.Visibility = Visibility.Visible;
                pp.onionBox.Visibility = Visibility.Visible;
                pp.rollBox.Visibility = Visibility.Visible;

                pp.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = pp;
            }
            else if(item is ThugsTBone thugs)
            {
                var ttb = new ItemCustomization();
                ttb.DataContext = thugs;
                ttb.itemName.Text = "Thugs T-Bone";

                ttb.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = ttb;
            }
            else if(item is Side side)
            {
                var s = new ItemCustomization();
                s.DataContext = side;
                s.itemName.Text = "Fried Miraak";
                s.sizeText.Visibility = Visibility.Visible;
                s.sizeMenu.Visibility = Visibility.Visible;

                s.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = s;
            }
            else if(item is AretinoAppleJuice aretino)
            {
                var aaj = new ItemCustomization();
                aaj.DataContext = aretino;
                aaj.itemName.Text = "Aretino Apple Juice";
                aaj.sizeText.Visibility = Visibility.Visible;
                aaj.sizeMenu.Visibility = Visibility.Visible;
                aaj.iceBox.Visibility = Visibility.Visible;

                aaj.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = aaj;
            }
            else if (item is CandlehearthCoffee candlehearth)
            {
                var cc = new ItemCustomization();
                cc.DataContext = candlehearth;
                cc.itemName.Text = "Candlehearth Coffee";
                cc.sizeText.Visibility = Visibility.Visible;
                cc.sizeMenu.Visibility = Visibility.Visible;
                cc.iceBox.Visibility = Visibility.Visible;

                cc.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = cc;
            }
            else if(item is MarkarthMilk markarth)
            {
                var mm = new ItemCustomization();
                mm.DataContext = markarth;
                mm.itemName.Text = "Markarth Milk";
                mm.sizeText.Visibility = Visibility.Visible;
                mm.sizeMenu.Visibility = Visibility.Visible;
                mm.iceBox.Visibility = Visibility.Visible;

                mm.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = mm;
            }
            else if(item is SailorSoda sailor)
            {
                var ss = new ItemCustomization();
                ss.DataContext = sailor;
                ss.itemName.Text = "Sailor Soda";
                ss.sizeText.Visibility = Visibility.Visible;
                ss.sizeMenu.Visibility = Visibility.Visible;
                ss.flavorText.Visibility = Visibility.Visible;
                ss.flavorMenu.Visibility = Visibility.Visible;
                ss.iceBox.Visibility = Visibility.Visible;

                ss.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = ss;
            }
            else if(item is WarriorWater warrior)
            {
                var ww = new ItemCustomization();
                ww.DataContext = warrior;
                ww.itemName.Text = "Warrior Water";
                ww.sizeText.Visibility = Visibility.Visible;
                ww.sizeMenu.Visibility = Visibility.Visible;
                ww.iceBox.Visibility = Visibility.Visible;
                ww.lemonBox.Visibility = Visibility.Visible;

                ww.doneButton.Visibility = Visibility.Visible;
                itemBorder.Child = ww;
            }
            return item;
        }
    }
}
