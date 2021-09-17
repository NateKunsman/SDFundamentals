using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenges
{
    [TestClass]
    public class Supercali
    {
        [TestMethod]
        public void TestMethod1()
        {
            string myWord = "Supercalifragilisticexpialidocious";
            foreach (char letter in myWord)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
            foreach (char letter in myWord)
            {
                if (letter != 'i')
                {
                    Console.WriteLine("Not an i");
                }
                else
                {
                    Console.WriteLine("i");
                }

            }
            int numberOfLetters = myWord.Length;

            Console.WriteLine(numberOfLetters);
        }
    }
}
