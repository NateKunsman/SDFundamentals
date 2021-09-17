using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum PastryType { Donut, Cake, Cupcake, Pie }
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch(input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("Goodbye");
                    break;
                case 3:
                    Console.WriteLine("I love you");
                    break;
                default:
                    Console.WriteLine("Just keep swimming");
                    break;

            }
            PastryType pastry = PastryType.Cake;

            switch(pastry)
            {
                case PastryType.Cake:
                    Console.WriteLine("Cost:$30");
                    break;
                case PastryType.Donut:
                case PastryType.Cupcake:
                case PastryType.Pie:
                    Console.WriteLine("Cost $5");
                    break;

            }
        }
    }
}
