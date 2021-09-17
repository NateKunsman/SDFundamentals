using ClassMethodsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter bob = new Greeter();
            bob.IsNice = true;
            Greeter jose = new Greeter(true);

            //bob.SayHello();

            //Console.WriteLine("Enter a number");
            //string numberAsString = Console.ReadLine();

            //int number = int.Parse(numberAsString);

            //bob.SayHelloMultipleTimes(number);

            /*            Console.WriteLine("What is my name?");
                        string input = Console.ReadLine();

                        bob.FirstName = input;

                        bob.FormalGreeting();*/

            bob.SayHello();

            bob.SayHello("Jake");

            Console.ReadLine();

        }


    }
}
