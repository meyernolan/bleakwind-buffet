using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Sides;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class SideTests
    {
        [Fact]
        public void SideNamePropertyShouldReturnNameOfSide()
        {
            FriedMiraak fried = new FriedMiraak();
            string name = fried.ToString();
            Assert.Equal(name, fried.Name);
        }
    }
}
