using _09_Interfaces_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _09_Interfaces_Tests
{
    [TestClass]
    public class IFruitTests
    {
        [TestMethod]
        public void PeelMethod_ShouldSetCorrectBoolValue()
        {
            IFruit banana = new Banana();
            //You cannot creat an instance of an interface
            //IFruit fruit = new IFruit();

            string output = banana.Peel();
            Console.WriteLine(output);

            //Assert
            Assert.IsTrue(banana.IsPeeled);
        }

        [TestMethod]
        public void InterfacesInLists_ShoulGetCorrectType()
        {
            var grapefruit = new Grapefruit();

            var fruitSalad = new List<IFruit>
            {
                grapefruit,
                new Banana(),
                new Strawberry(),
                new Pear()
            };

            foreach(var fruit in fruitSalad)
            {
                Console.WriteLine(fruit.Name);
                Console.WriteLine(fruit.Peel());

                Assert.IsInstanceOfType(fruit, typeof(IFruit));
            }

            Console.WriteLine(grapefruit.Squeeze());

            Assert.IsInstanceOfType(grapefruit, typeof(Grapefruit));
        }

        //Helper Method
        private string GetNameOfFruit(IFruit fruit)
        {
            return $"This fruit is a {fruit.Name}";
        }

        [TestMethod]
        public void InterfaceInMethodParameter_ShouldReturnCorrectString()
        {
            var strawberry = new Strawberry();

            var output = GetNameOfFruit(strawberry);

            Console.WriteLine(output);
            Assert.IsTrue(output.Contains("This fruit is a Strawberry"));
        }

        [TestMethod]
        public void PatternMatchingExample_BeCorrectType()
        {
            var fruitSalad = new List<IFruit>
            {
                new Strawberry(),
                new Banana(),
                new Banana(true),
                new Grapefruit(),
                new Grapefruit(),
                new Pear(),
                new Grapefruit(true)
            };
                  //var = IFRuit (in this instance)
            foreach(var fruit in fruitSalad)
            {
                if(fruit is Grapefruit grapefruit)
                {
                    Console.WriteLine(fruit.Name);
                    Console.WriteLine(grapefruit.Name);
                    if (!grapefruit.IsPeeled)
                    {
                        Console.WriteLine(grapefruit.Peel());
                    }
                    else
                    {
                        Console.WriteLine("This is a Grapefruit that is not peeled");
                    }
                }
                else if(fruit.GetType() == typeof(Strawberry))
                {
                    Strawberry strawberry = (Strawberry)fruit;

                    Console.WriteLine("This is a strawberry");
                }
                else if (fruit is Pear pear)
                {
                    if (pear.IsPeeled)
                    {
                        Console.WriteLine("This is a peeled pear");
                        Console.WriteLine(pear.Peel());
                    }
                    else
                    {
                        Console.WriteLine("This is pear is not peeled");
                    }
                }
                else if (fruit.IsPeeled)
                {
                    Console.WriteLine("This is a peeled Banana");
                }
                else
                {
                    Console.WriteLine("This is an unpeeled banana");
                }
            }
        }
    }
}
