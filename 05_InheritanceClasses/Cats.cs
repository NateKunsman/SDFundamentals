using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_InheritanceClasses
{
               //derived  //base class
    public class Cat : Animal 
    {
        public Cat()
        {
            Console.WriteLine("This Made a Cat");
        }

        public Cat(bool isMammal) : base(isMammal)
        {
         
        }

        public double ClawLength { get; set; }

        public virtual void MakeSounds()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("It moves quickly!");

        }
    }

    public class RagdollCat : Cat
    { 
        public override void MakeSound()
        {
            Console.WriteLine("Purrrr");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} meanders across the floor.");
        }
    }

    public class Calico : Cat
    {
        public Calico()
        {
            Console.WriteLine("This constuctor made a Calico");
        }
    }
}
