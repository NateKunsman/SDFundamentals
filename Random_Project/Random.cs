using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Random_Project
{
    [TestClass]
    public class Random
    {
        [TestMethod]
        public void InfinityLoop_WritesHelloWorldToConsoleInfinitel()
        {
            int age = 23;

            if (age <= 18)

            {

                Console.WriteLine($"You are: {age}.");

            }

            else if (age > 18 && age <= 35)

            {

                Console.WriteLine($"How are you? You are: {age}.");

            }

            else

            {

                Console.WriteLine("...");

            }
        }
    }
}
