using System;
using System.Configuration;
using System.Linq;
using Xunit;

namespace UnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestMethod1()
        {
            Console.WriteLine("Test");
            var Test = Console.ReadLine();
            Console.WriteLine(Test);
        }
    }
}
