using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class EntreeTests
    {
        [Fact]
        public void EntreeNamePropertyShouldReturnNameOfEntree()
        {
            BriarheartBurger briarheart = new BriarheartBurger();
            string name = briarheart.ToString();
            Assert.Equal(name, briarheart.Name);
        }
    }
}
