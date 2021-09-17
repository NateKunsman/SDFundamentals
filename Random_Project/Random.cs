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
            string str = "Hello World";

            for (int i = 0; i <= str.Length - 1; i++)
            {
                Console.WriteLine(str[i]);
            }
        }
    }
}
