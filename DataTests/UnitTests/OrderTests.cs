using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.Data;
using System.Linq;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void NumberShouldOriginallyBeSetToOne()
        {
            Order order = new Order();
            uint one = 1;
            order.Number = one;
            Assert.Equal(one, order.Number);
        }

        [Fact]
        public void ChangingNumberNotifiesNumberProperty()
        {
            Order order = new Order();
            Assert.PropertyChanged(order, "Number", () =>
            {
                order.Number = 1;
            });
        }


        [Fact]
        public void AddingItemToOrderAddsToCollection()
        {
            BriarheartBurger briarheart = new BriarheartBurger();
            Order order = new Order();
            order.Add(briarheart);
            Assert.NotEmpty(order);
        }
        
        [Fact]
        public void IfEntreeSideAndDrinkAddedCreateCombo()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Order order = new Order();
            order.Add(bb);
            order.Add(cc);
            order.Add(fm);
            Combo combo = new Combo(bb, fm, cc);
            Assert.NotEqual(bb, order.OfType<Entree>().FirstOrDefault<Entree>());
            Assert.NotEqual(fm, order.OfType<Side>().FirstOrDefault<Side>());
            Assert.NotEqual(cc, order.OfType<Drink>().FirstOrDefault<Drink>());
            int one = 1;
            Assert.Equal(one, order.Count);
        }
        

        [Fact]
        public void MakingChangesToPriceOrCaloriesOfItemInCollectionFiresCollectionItemChangedListener()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            Assert.PropertyChanged(order, "Total", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                cc.Size = Size.Large;
            });
            Assert.PropertyChanged(order, "Tax", () =>
            {
                cc.Size = Size.Medium;
            });
            Assert.PropertyChanged(order, "Calories", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void SubtotalShouldBeCorrect()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            double price = cc.Price;
            Assert.Equal(price, order.Subtotal);
        }

        [Fact]
        public void TotalShouldBeCorrect()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            double price = cc.Price;
            double taxRate = 0.12;
            double Total = price + price * taxRate;
            Assert.Equal(Total, order.Total);
        }

        [Fact]
        public void TaxShouldBeCorrect()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            double price = cc.Price;
            double taxRate = 0.12;
            double Tax = price * taxRate;
            Assert.Equal(Tax, order.Tax);
        }


        [Fact]
        public void TaxRateShouldBeCorrect()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            double taxRate = 0.12;
            Assert.Equal(taxRate, order.SalesTaxRate);
        }


        [Fact]
        public void TaxRateShouldBeSettable()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            double taxRate = 0.13;
            order.SalesTaxRate = taxRate;
            Assert.Equal(taxRate, order.SalesTaxRate);
        }

        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Order order = new Order();
            order.Add(cc);
            uint calories = cc.Calories;
            Assert.Equal(calories, order.Calories);
        }
    }
}
