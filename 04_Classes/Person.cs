using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string HairColor { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public Vehicle Transport { get; set; }

        //Method
        public void Jump()
        {
            Console.WriteLine($"{FirstName} jumps in the air");
            return;
        }

        //Jump

        //Run

        //Walk

        //Eat
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} eats {food}");
        }
    }
}
