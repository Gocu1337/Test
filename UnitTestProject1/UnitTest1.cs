using System;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            var kasa = new UnitTest1();
            Assert.Equal(10,10);
        }

        [Fact]
        
        public void TestMethod2()
        {
            int x = 1;
            int y = 3;
            Assert.True(y>x);
            Assert.False(y<x);
            Assert.NotEqual(x,y);

        }

        [Fact]

        public void TestMethod3()
        {
            var money = new UnitTest1();
            Assert.Equal(100, 10);
        }
    }
}
