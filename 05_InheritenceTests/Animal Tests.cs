using _05_InheritanceClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _05_InheritenceTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void MovementTest_ShouldWriteToConsoleContainingAnimalTypeName()
        {
            Animal animalOne = new Animal();
            animalOne.Move();
        }

        [TestMethod]
        public void CatMovementTest_ShouldWriteToConsoleContainingCatTypeNamePlusSecondLineSpecificToCatType()
        {
            Cat catOne = new Cat();
            catOne.Move();

            catOne.ClawLength = 3.7;
        }

        [TestMethod]
        public void RagdollMethodTest_ShouldOutputToConsolRagdollCatSpecificWriteLine()
        {
            RagdollCat whiskers = new RagdollCat();
            Cat snickers = new RagdollCat();

            whiskers.Move();
            snickers.MakeSounds();

        }

        [TestMethod]
        public void CalicoContructorTest_ShouldOutputToConsoleProperWritelines()
        {
            Cat fluffy = new Calico();
            Cat fluffBall = new Calico(false);

       
        }
        [TestMethod]
        public void CheckingTypes_TypesShouldBehaveAsDeclared()
        {
            Calico catOne = new Calico();
            Animal animalOne = new Calico();

            List<Animal> animals = new List<Animal>();

            animals.Add(catOne);
            animals.Add(new RagdollCat());
            animals.Add(new Animal);
            animals.Add(new Cat());

            foreach(Animal animal in an)
        }
    }
}
