using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _02_Conditionals
{
    [TestClass]
    public class Ternary
    {
        [TestMethod]
        public void Ternaries()
        {
            // (Condition/Boolean, ? if TrueDoThis : ifFalseDoThis;

            int numberOfDucks = 10;
            string answer = (numberOfDucks > 8) ? "You're a super ducky!" : "Mediocre ducker";

            Console.WriteLine((numberOfDucks == 12) ? "That's a dozen" : "That is not a dozen");
            Console.WriteLine((numberOfDucks == 12) ? "That's a dozen" : "That is not a dozen");

            Console.WriteLine("hello");

        }
    }
}
