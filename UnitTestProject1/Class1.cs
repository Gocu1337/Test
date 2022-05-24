using System;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting;
using System.Xml.Schema;
using UnitTestProject1.UnitTestingDemo;
using Xunit;
using Xunit.Sdk;

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
