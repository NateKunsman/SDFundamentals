using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ReferenceTypes
    {
        [TestMethod]
        public void Strings()
        {
            //Declaration
            string thisisDeclaration;

            //Initialization
            thisisDeclaration = "This is initialized";

            string declrationAndInitialization = "This does both!";

            string singleLetter = "a";

            //String Manipulation

            string firstName = "Joe";
            string lastName = "Smith";

            //Concatenation
            string concatFullName = firstName + " " + lastName;

            //Composite Formatting
            string compositeFullName = string.Format(" {0} {1}", firstName, lastName);

            //Interpolation
            string interpolatedFullName = $"{firstName} {lastName}";

            Console.WriteLine(concatFullName);
            Console.WriteLine(compositeFullName);
            Console.WriteLine(interpolatedFullName);


        }

        [TestMethod]
        public void Collections()

        {
            string stringExample = "Hello World!";

            string[] stringArray = { "Hello", "What", "Why", "When", stringExample };

            string[] threeSpaces = new string[3];

            Console.WriteLine(stringArray[4]);

            stringArray[4] = "World";

            Console.WriteLine(stringArray[4]);

            //Lists
            List<string> listOfStrings = new List<string>();
            List<int> listOfNumbers = new List<int>();

            listOfStrings.Add("Hello");
            listOfStrings.Add("Two");

            Console.WriteLine(listOfStrings[0]);


            int a = 5;
            int b = a;

            a = 7;
            Console.WriteLine(a + " " + b);

            listOfNumbers.Add(a);
            listOfNumbers.Add(b);

            List<int> secondListOFNumbers = listOfNumbers;

            Console.WriteLine(listOfNumbers[0] + " " + secondListOFNumbers);

            listOfNumbers[0] = 13;
            Console.WriteLine(listOfNumbers[0] + " " + secondListOFNumbers[0]);



            //Queues
            //First In First Out
            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first");
            firstInFirstOut.Enqueue("I'm second");

            Console.WriteLine(firstInFirstOut.Dequeue());
            Console.WriteLine(firstInFirstOut.Dequeue());

            //Stacks
            //Last in First Out
            Stack<string> LIFO = new Stack<string>();
            LIFO.Push("I'm first");
            LIFO.Push("I'm second");

            Console.WriteLine(LIFO.Pop());
            Console.WriteLine(LIFO.Pop());

            //Dictionaries
            //Work as lists (indexed in the way we want them to be)
            Dictionary<string, string> dictionaryExample = new Dictionary<string, string>();

            dictionaryExample.Add("Bee", "Pointy sting ouchy");

            string bee = dictionaryExample["Bee"];
            Console.WriteLine(bee);

            Dictionary<string, string> numberDictionary = new Dictionary<int, string>();
            numberDictionary.Add(7, "Bond");

            Console.WriteLine(numberDictionary[7]);
            numberDictionary.Add(-777, "Unlucky");

            //Linked List (Contains Value and pointer to next list item)
            //HashSet
            //Stores Unique values (AKA if it has 7 stored cannot store 7 again)

        }

        [TestMethod]
        public void Classes()                                   
        {
            Random rng = new Random();

            int randomNumber = rng.Next(0, 10);

            Console.WriteLine(randomNumber);


        }
    }
}
