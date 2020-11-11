/*
 * Author: Zachery Brunner
 * Modified By: Nolan Meyer
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal(6.44, ttb.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone ttb = new ThugsTBone();
            uint calories = 982;
            Assert.Equal(calories, ttb.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Empty(ttb.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone ttb = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", ttb.ToString());
        }

        [Fact]
        public void ShouldBeAbleToCastToEntreeAndIOrderItem()
        {
            Assert.IsAssignableFrom<IOrderItem>(new ThugsTBone());
            Assert.IsAssignableFrom<Entree>(new ThugsTBone());
        }

        [Fact]
        public void ImplementsINotifyPropertyChangedInterface()
        {
            var ttb = new ThugsTBone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ttb);
        }

        [Fact]
        public void DescriptionShouldReturnADescriptionOfItem()
        {
            ThugsTBone item = new ThugsTBone();
            Assert.Equal("Juicy T-Bone, not much else to say.", item.Description);
        }
    }
}