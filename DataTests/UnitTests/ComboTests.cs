using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void NewComboShouldSetSideEntreeAndDrink()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            Assert.PropertyChanged(order, "Entree", () =>
            {
                order.Entree = bb;
            });
            Assert.PropertyChanged(order, "Side", () =>
            {
                order.Side = fm;
            });
            Assert.PropertyChanged(order, "Drink", () =>
            {
                order.Drink = cc;
            });
        }


        [Fact]
        public void NamePropertyReturnsComboAsString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            Assert.Equal("Combo", order.Name);
        }

        [Fact]
        public void ToStringReturnsComboAsString()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            Assert.Equal("Combo", order.ToString());
        }


        [Fact]
        public void ShouldBeAbleToSetDrinkEntreeAndSide()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            order.Entree = bb;
            Assert.Equal(bb, order.Entree);
            order.Drink = cc;
            Assert.Equal(cc, order.Drink);
            order.Side = fm;
            Assert.Equal(fm, order.Side);
        }


        [Fact]
        public void NameShouldBeCombo()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            Assert.Equal("Combo", order.Name);
        }


        [Fact]
        public void PriceShouldBeSet()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            double price = bb.Price + cc.Price + fm.Price - 1.00;
            Assert.Equal(price, order.Price);
        }

        [Fact]
        public void CaloriesShouldBeSet()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            uint calories = bb.Calories + cc.Calories + fm.Calories;
            Assert.Equal(calories, order.Calories);
        }


        [Theory]
        [InlineData(true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeIce, bool includeCream)
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            cc.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", order.SpecialInstructions);
            bb.Bun = includeBun;
            bb.Ketchup = includeKetchup;
            bb.Mustard = includeMustard;
            bb.Pickle = includePickle;
            bb.Cheese = includeCheese;
            if (bb.Bun && bb.Ketchup && bb.Mustard && bb.Pickle && bb.Cheese)
            {
                Assert.DoesNotContain("Hold bun", bb.SpecialInstructions);
                Assert.DoesNotContain("Hold ketchup", bb.SpecialInstructions);
                Assert.DoesNotContain("Hold mustard", bb.SpecialInstructions);
                Assert.DoesNotContain("Hold pickle", bb.SpecialInstructions);
                Assert.DoesNotContain("Hold cheese", bb.SpecialInstructions);
            }
            else
            {
                Assert.Contains("Hold bun", bb.SpecialInstructions);
                Assert.Contains("Hold ketchup", bb.SpecialInstructions);
                Assert.Contains("Hold mustard", bb.SpecialInstructions);
                Assert.Contains("Hold pickle", bb.SpecialInstructions);
                Assert.Contains("Hold cheese", bb.SpecialInstructions);
            }
        }

        [Fact]
        public void DescriptionShouldReturnADescriptionOfItem()
        {
            BriarheartBurger bb = new BriarheartBurger();
            CandlehearthCoffee cc = new CandlehearthCoffee();
            FriedMiraak fm = new FriedMiraak();
            Combo order = new Combo(bb, fm, cc);
            Assert.Equal("", order.Description);
        }
    }
}
