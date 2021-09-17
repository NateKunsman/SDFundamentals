using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _03_Loops
{
    [TestClass]
    public class LoopExamples
    {
        //While, for, foreach, dowhile
        [TestMethod]
        public void WhileLoops ()
        {
            // Keyword:while (condition(true/false)) { body of code that will be Looped }

            int counter = 1;

            while (counter != 10)
            {
                Console.WriteLine(counter);
                //counter = counter + 1;
                //counter += 1;
                counter++;
            }

            counter = 1;
            while(true)
            {
                Console.WriteLine(counter);
                if (counter == 7)
                {
                    Console.WriteLine("Goal reached.");
                    break;
                }

                counter++;
            }

            Random rng = new Random();
            bool isRunning = true;
            int 
















                bool isRunning = true;
                int someCount;

                while (isRunning)
                {
                    //0 (inclusive) 21(Non inclusive) so random number between 0 and 20
                    someCount = rng.Next(0, 21);

                    if(someCount == 13 || someCount < 5)
                }
            }

        }











        [TestMethod]
        public void ForLoops()
        {
            int targetNumber = 21;
            //1 for is the Keyword
            //2 Starting point
            //3 Condition to continue looping
            //4 what to do after each loop
            //5 Body of code to loop through
            //1     //2     //3         //4
            for (int i = 0; i < targetNumber; i ++)
            {
                //5
                Console.WriteLine(i);
            }

            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethen" };

            for(int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Good Morning {students[i]}");
            }

            
        }
        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "David", "Nate", "Anastacia", "Jeffrey", "Ethen" };

            //1 foreach keyword
            //2 type of the collection
            //3 name of the current iteration
            //4 in keyword used to seperate the individual item an the collection
            //5 collection being iterated through
            //6 body of code to loop through
            //1     //2    //3        //4   //5
            foreach(string studentName in students)
            {
               //6
                Console.WriteLine(studentName + " is in class");
            }

            string myName = "Simon William Pawlak";
            foreach( char letter in myName)
            {
                if(letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoop()
        {
            //do while loops always run at least once
            //1 do Keyword
            //2 Body of code to loop
            //3 while keyword
            //4 condition to continue looping
            //5

            int counter = 0;
            //1
            do
            {
                //2
                Console.WriteLine("Hello" + counter);
                counter++;
            }
            //3             //4
            while (counter < 5);
        }

        //goto keyword
        //Goes to specific  line in code
    }
}
