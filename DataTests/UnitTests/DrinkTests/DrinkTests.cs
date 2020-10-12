using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Drinks;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class DrinkTests
    {
        [Fact]
        public void SideNamePropertyShouldReturnNameOfSide()
        {
            CandlehearthCoffee candlehearth = new CandlehearthCoffee();
            string name = candlehearth.ToString();
            Assert.Equal(name, candlehearth.Name);
        }
    }
}
