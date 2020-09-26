using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreesMethodShouldReturnAllEntreeItems()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Entrees());
            //Assert.Collection<IOrderItem>(list, item => Assert.Equal(new BriarheartBurger(), item));
            Assert.Collection<IOrderItem>(list, item => item.ToString().Contains("Briarheart Burger"), item => item.ToString().Contains("Double Draugr"), 
                                        item => item.ToString().Contains("Garden Orc Omelette"), item => item.ToString().Contains("Philly Poacher"),
                                        item => item.ToString().Contains("Smokehouse Skeleton"), item => item.ToString().Contains("Thalmor Triple"),
                                        item => item.ToString().Contains("Thugs T-Bone"));
        }


        /*Blackberry,
        Cherry,
        Grapefruit,
        Lemon,
        Peach,
        Watermelon*/

        [Fact]
        public void DrinksMethodShouldReturnAllDrinkItems()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Drinks());
            Assert.Collection<IOrderItem>(list, item => item.ToString().Contains("Small Aretino Apple Juice"), item => item.ToString().Contains("Small Candlehearth Coffee"),
                                                item => item.ToString().Contains("Small Markarth Milk"), item => item.ToString().Contains("Small Warrior Water"), 
                                                item => item.ToString().Contains("Medium Aretino Apple Juice"), item => item.ToString().Contains("Medium Candlehearth Coffee"),
                                                item => item.ToString().Contains("Medium Markarth Milk"), item => item.ToString().Contains("Medium Warrior Water"), 
                                                item => item.ToString().Contains("Large Aretino Apple Juice"), item => item.ToString().Contains("Large Candlehearth Coffee"),
                                                item => item.ToString().Contains("Large Markarth Milk"), item => item.ToString().Contains("Large Warrior Water"),
                                                item => item.ToString().Contains("Small Blackberry Sailor Soda"), item => item.ToString().Contains("Medium Blackberry Sailor Soda"),
                                                item => item.ToString().Contains("Large Blackberry Sailor Soda"), item => item.ToString().Contains("Small Cherry Sailor Soda"), 
                                                item => item.ToString().Contains("Medium Cherry Sailor Soda"), item => item.ToString().Contains("Large Cherry Sailor Soda"),
                                                item => item.ToString().Contains("Small Grapefruit Sailor Soda"), item => item.ToString().Contains("Medium Grapefruit Sailor Soda"),
                                                item => item.ToString().Contains("Large Grapefruit Sailor Soda"), item => item.ToString().Contains("Small Lemon Sailor Soda"), 
                                                item => item.ToString().Contains("Medium Lemon Sailor Soda"), item => item.ToString().Contains("Large Lemon Sailor Soda"),
                                                item => item.ToString().Contains("Small Peach Sailor Soda"), item => item.ToString().Contains("Medium Peach Sailor Soda"),
                                                item => item.ToString().Contains("Large Peach Sailor Soda"), item => item.ToString().Contains("Small Watermelon Sailor Soda"),
                                                item => item.ToString().Contains("Medium Watermelon Sailor Soda"), item => item.ToString().Contains("Large Watermelon Sailor Soda"));
        }

        [Fact]
        public void SidesMethodShouldReturnAllSides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.Sides());
            Assert.Collection<IOrderItem>(list, item => item.ToString().Contains("Small Dragonborn Waffle Fries"), item => item.ToString().Contains("Small Fried Miraak"),
                                                item => item.ToString().Contains("Small Mad Otar Grits"), item => item.ToString().Contains("Small Vokun Salad"),
                                                item => item.ToString().Contains("Medium Dragonborn Waffle Fries"), item => item.ToString().Contains("Medium Fried Miraake"),
                                                item => item.ToString().Contains("Medium Mad Otar Grits"), item => item.ToString().Contains("Medium Mad Otar Grits"), 
                                                item => item.ToString().Contains("Large Dragonborn Waffle Fries"), item => item.ToString().Contains("Large Fried Miraak"),
                                                item => item.ToString().Contains("Large Mad Otar Grits"), item => item.ToString().Contains("Large Mad Otar Grits"));
        }


        [Fact]
        public void FullMenuMethodShouldReturnAllMenuItems()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            list.AddRange(Menu.FullMenu());
            Assert.Collection<IOrderItem>(list, item => item.ToString().Contains("Briarheart Burger"), item => item.ToString().Contains("Double Draugr"),
                                        item => item.ToString().Contains("Garden Orc Omelette"), item => item.ToString().Contains("Philly Poacher"),
                                        item => item.ToString().Contains("Smokehouse Skeleton"), item => item.ToString().Contains("Thalmor Triple"),
                                        item => item.ToString().Contains("Thugs T-Bone"),  item => item.ToString().Contains("Small Dragonborn Waffle Fries"),
                                        item => item.ToString().Contains("Small Fried Miraak"),
                                        item => item.ToString().Contains("Small Mad Otar Grits"), item => item.ToString().Contains("Small Vokun Salad"),
                                        item => item.ToString().Contains("Medium Dragonborn Waffle Fries"), item => item.ToString().Contains("Medium Fried Miraake"),
                                        item => item.ToString().Contains("Medium Mad Otar Grits"), item => item.ToString().Contains("Medium Mad Otar Grits"),
                                        item => item.ToString().Contains("Large Dragonborn Waffle Fries"), item => item.ToString().Contains("Large Fried Miraak"),
                                        item => item.ToString().Contains("Large Mad Otar Grits"), item => item.ToString().Contains("Large Mad Otar Grits"), 
                                        item => item.ToString().Contains("Small Aretino Apple Juice"), item => item.ToString().Contains("Small Candlehearth Coffee"),
                                        item => item.ToString().Contains("Small Markarth Milk"), item => item.ToString().Contains("Small Warrior Water"),
                                        item => item.ToString().Contains("Medium Aretino Apple Juice"), item => item.ToString().Contains("Medium Candlehearth Coffee"),
                                        item => item.ToString().Contains("Medium Markarth Milk"), item => item.ToString().Contains("Medium Warrior Water"),
                                        item => item.ToString().Contains("Large Aretino Apple Juice"), item => item.ToString().Contains("Large Candlehearth Coffee"),
                                        item => item.ToString().Contains("Large Markarth Milk"), item => item.ToString().Contains("Large Warrior Water"),
                                        item => item.ToString().Contains("Small Blackberry Sailor Soda"), item => item.ToString().Contains("Medium Blackberry Sailor Soda"),
                                        item => item.ToString().Contains("Large Blackberry Sailor Soda"), item => item.ToString().Contains("Small Cherry Sailor Soda"),
                                        item => item.ToString().Contains("Medium Cherry Sailor Soda"), item => item.ToString().Contains("Large Cherry Sailor Soda"),
                                        item => item.ToString().Contains("Small Grapefruit Sailor Soda"), item => item.ToString().Contains("Medium Grapefruit Sailor Soda"),
                                        item => item.ToString().Contains("Large Grapefruit Sailor Soda"), item => item.ToString().Contains("Small Lemon Sailor Soda"),
                                        item => item.ToString().Contains("Medium Lemon Sailor Soda"), item => item.ToString().Contains("Large Lemon Sailor Soda"),
                                        item => item.ToString().Contains("Small Peach Sailor Soda"), item => item.ToString().Contains("Medium Peach Sailor Soda"),
                                        item => item.ToString().Contains("Large Peach Sailor Soda"), item => item.ToString().Contains("Small Watermelon Sailor Soda"),
                                        item => item.ToString().Contains("Medium Watermelon Sailor Soda"), item => item.ToString().Contains("Large Watermelon Sailor Soda")
                                        );
        }
    }
}
