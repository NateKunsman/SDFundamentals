using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsLibrary
{
    //camelCase thisIsWrittenInCamelCase is used for local variables
    //PascalCase ThisIsPascalCase used for methods and properties
    public class Greeter
    {
        //Feilds

        //Constructors

        //Properties

        //Methods

        //This is an example of a constructor
        public Greeter() { }

        public Greeter(bool isThisANiceGreeter)
        {
            IsNice = isThisANiceGreeter;
        }

        public Greeter(bool isNice, string firstName)
        {
            FirstName = firstName;
            IsNice = isNice;
        }


        //Properties
        public bool IsNice { get; set; }
        public string FirstName { get; set; }

        //Method
                    //Method Signature
        public void SayHello()
        {
            Console.WriteLine("Hello, stop being so happy... Just kidding! You're awesome!");
        }


        public void SayHelloMultipleTimes(int numberOfTimes)
        {
            for(int i=0; i < numberOfTimes; i++)
            {
            Console.WriteLine("Hello");
            }

        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is {FirstName}");
        }

        public void FormalGreeting()
        {
            SayHello();
            IntroduceYourself();
        }

        public void GreetSomeneElse()
        {
            Console.WriteLine("What");
        }

        public void SayHello(string name)
        {
            Console.WriteLine("Hello" + name);
        }
    }
}
