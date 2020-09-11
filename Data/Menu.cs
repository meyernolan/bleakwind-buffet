using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
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
                drinks.Add(new SailorSoda() { Size = size });
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
    }
}
