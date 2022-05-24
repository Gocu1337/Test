using System;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Xml.Schema;
using UnitTestProject1.UnitTestingDemo;
using Xunit;
using Xunit.Sdk;

namespace UnitTestProject1
{
    namespace UnitTestingDemo
    {
        public static class MathOperation
        {
            public static double Dodawanie(double number1, double number2)
            {
                return (number1 + number2);
            }

            public static double Odejmowanie(double number1, double number2)
            {
                return (number1 - number2);
            }

            public static double Mnozenie(double number1, double number2)
            {
                return (number1 * number2);
            }

            public static double Dzielenie(double number1, double number2)
            {
                return (number1 / number2);
            }
        }
    }

    public class UnitTest1
    {

        [Fact]
        public void TestMethod1()
        {
            var kasa = new UnitTest1();
            Assert.Equal(10, 10);
        }

        [Fact]

        public void TestMethod2()
        {
            int x = 1;
            int y = 3;
            Assert.True(y > x);
            Assert.False(y < x);
            Assert.NotEqual(x, y);

        }

        [Fact]

        public void TestMethod3()
        {
            int expected = 49;
            int actual = 7 * 7;
            Assert.Equal(expected, actual);


        }

        [Fact]

        public void TeatMethod4()
        {
            Assert.False(false, "Niedziała");
        }

        [Fact]

        public void TestMethod5()
        {
            string one = "Prawda";
            string two = "Fałsz";
            ;
            String.Equals(one, two);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(7, 3, 4)]
        [InlineData(-1, -3, 2)]
        public void TestMethod6(int first, int second, int third)
        {
            Assert.Equal(first, second + third);
        }

        [Fact]

        public void TestMethods7()
        {
            Decimal taxRate = (Decimal).035;
            Decimal expected = (Decimal).035;

            Assert.Equal(expected, taxRate);
        }


        public class MathOperationTest
        {


            [Theory]
            [InlineData(4.5,1.5,6)]
            public void Dodawanie_test(float num1, float num2, float expectedValue)
            {

                var sum = MathOperation.Dodawanie(num1, num2);

                Assert.Equal(expectedValue, sum, 1);
            }
        }

        [Theory]
        [InlineData(2.9,3.1,8.99)]
        public void Mnozenie_test(float num1, float num2, float expectedValue)
        {
            var mult = MathOperation.Mnozenie(num1, num2);

            Assert.Equal(expectedValue, mult, 2);
        }

        [Theory]
        [InlineData(1.9,3.5,-1.6)]
        public void Odejmowanie_test(float num1, float num2, float expectedValue)
        {
            var sub = MathOperation.Odejmowanie(num1, num2);

            Assert.Equal(expectedValue, sub, 1);
        }

        [Theory]
        [InlineData(2.9,3.1,0.94)]
        [InlineData(3.6, 3.1, 1.16)]
        public void Dzielenie_test(float num1, float num2, float expectedValue)
        {
            var div = MathOperation.Dzielenie(num1, num2);

            Assert.Equal(expectedValue, div, 2);
        }
    }
}
