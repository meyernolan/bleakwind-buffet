﻿/*
 * Author: Nolan Meyer
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWaterTests.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = false;
            Assert.False(ww.Ice);
            ww.Ice = true;
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact] 
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = Size.Medium;
            Assert.Equal(Size.Medium, ww.Size);
            ww.Size = Size.Large;
            Assert.Equal(Size.Large, ww.Size);
            ww.Size = Size.Small;
            Assert.Equal(Size.Small, ww.Size);
        }

        [Fact]
        public void ShouldHaveCorrectPrice()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(0.00, ww.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCalories()
        {
            WarriorWater ww = new WarriorWater();
            uint calories = 0;
            Assert.Equal(calories, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            ww.Lemon = includeLemon;
            if(ww.Ice)
            {
                if(ww.Lemon)
                {
                    Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
                    Assert.Contains("Add lemon", ww.SpecialInstructions);
                }
                else
                {
                    Assert.DoesNotContain("Hold ice", ww.SpecialInstructions);
                    Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
                }
            }
            else
            {
                if(ww.Lemon)
                {
                    Assert.Contains("Hold ice", ww.SpecialInstructions);
                    Assert.Contains("Add lemon", ww.SpecialInstructions);
                }
                else
                {
                    Assert.Contains("Hold ice", ww.SpecialInstructions);
                    Assert.DoesNotContain("Add lemon", ww.SpecialInstructions);
                }
            }
        }


        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ShouldBeAbleToCastToDrinkAndIOrderItem()
        {
            Assert.IsAssignableFrom<IOrderItem>(new WarriorWater());
            Assert.IsAssignableFrom<Drink>(new WarriorWater());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }


        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Small;
            });

            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Large;
            });
            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Small;
            });

            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Large;
            });
            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Small;
            });

            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Large;
            });
        }

        [Fact]
        public void ImplementsINotifyPropertyChangedInterface()
        {
            var ww = new WarriorWater();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ww);
        }

        [Fact]
        public void DescriptionShouldReturnADescriptionOfItem()
        {
            WarriorWater item = new WarriorWater();
            Assert.Equal("It’s water. Just water.", item.Description);
        }
    }
}
