/*
 * Author: Nolan Meyer
 * Class name: Menu.cs
 * Purpose: represents a menu
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A class that represents a menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Puts all the entrees into a list of IOrderItem items
        /// </summary>
        /// <returns>The list of Entrees as IOrderItem items</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new ThalmorTriple());
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmelette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new ThugsTBone());
            entrees.Add(new SmokehouseSkeleton());
            return entrees;
        }

        /// <summary>
        /// Puts all the sides into a list of IOrderItem items
        /// </summary>
        /// <returns>The list of Sides as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                sides.Add(new DragonbornWaffleFries() { Size = size });
                sides.Add(new FriedMiraak() { Size = size });
                sides.Add(new MadOtarGrits() { Size = size });
                sides.Add(new VokunSalad() { Size = size });
            }
            return sides;
        }

        /// <summary>
        /// Puts all the drinks into a list of IOrderItem items
        /// </summary>
        /// <returns>The list of drinks as IOrderItems</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                drinks.Add(new AretinoAppleJuice() { Size = size });
                drinks.Add(new CandlehearthCoffee() { Size = size });
                drinks.Add(new MarkarthMilk() { Size = size });
                foreach(SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    drinks.Add(new SailorSoda() { Size = size , Flavor = flavor});
                }
                drinks.Add(new WarriorWater() { Size = size });
            }
            return drinks;
        }

        /// <summary>
        /// Puts all the items on the menu into a list of IOrderItem items
        /// </summary>
        /// <returns>The list of all items on the menu as IOrderItems</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> fullMenu = new List<IOrderItem>();
            fullMenu.AddRange(Entrees());
            fullMenu.AddRange(Sides());
            fullMenu.AddRange(Drinks());
            return fullMenu;
        }

        /// <summary>
        /// gets the types of items that can be ordered
        /// </summary>
        public static string[] OrderItems
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        
        /// <summary>
        /// Searches the list for items with the keyword str
        /// </summary>
        /// <param name="orderItems">The list of items</param>
        /// <param name="str">The keyword being searched for</param>
        /// <returns>A list with items that have the keyword in their name</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> orderItems, string str)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (str == null) return FullMenu();

            foreach (IOrderItem item in FullMenu())
            {
                if ((item.Name != null && item.Name.ToLower().Contains(str.ToLower())) || item.Description.ToLower().Contains(str.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        
        /// <summary>
        /// Filters the items by the categories selected
        /// </summary>
        /// <param name="orderItems">The list of items</param>
        /// <param name="categories">The categories selected</param>
        /// <returns>The list filtered by the categories selected</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> orderItems, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return orderItems;
            List<IOrderItem> results = new List<IOrderItem>();
            if(categories.Contains("Entree") && categories.Contains("Side") && categories.Contains("Drink"))
            {
                return orderItems;
            }
            if(categories.Contains("Entree") && categories.Contains("Side"))
            {
                foreach(IOrderItem item in orderItems)
                {
                    if(item is Entree || item is Side)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (categories.Contains("Drink") && categories.Contains("Side"))
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item is Drink || item is Side)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (categories.Contains("Entree") && categories.Contains("Drink"))
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item is Entree || item is Drink)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (categories.Contains("Entree"))
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item is Entree)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (categories.Contains("Drink"))
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item is Drink)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (categories.Contains("Side"))
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item is Side)
                    {
                        results.Add(item);
                    }
                }
                return results;
            }

            return results;
        }

        /// <summary>
        /// Filters the list of items by calories
        /// </summary>
        /// <param name="orderItems">The list of items</param>
        /// <param name="min">The minimum amount of calories the item can have</param>
        /// <param name="max">The maximum amount of calories the item can have</param>
        /// <returns>The list filtered by calories</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> orderItems, int? min, int? max)
        {
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in orderItems)
            {
                if (item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the list of items by price
        /// </summary>
        /// <param name="orderItems">The list of items</param>
        /// <param name="min">The minimum price the item can have</param>
        /// <param name="max">The maximum price the item can have</param>
        /// <returns>The list filtered by price</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> orderItems, double? min, double? max)
        {
            if (min == null && max == null) return orderItems;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in orderItems)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in orderItems)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }
    }
}
