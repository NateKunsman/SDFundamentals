using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorningChallange_3_Calculator;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class Calculator
    {
       
        //create a field that is basically an ACTUAL CALCULATOR for us to use
        public Calculator calc = new Calculator();

        [TestMethod]
        public void TestSum_DoubleOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            //Addition +
            double expected = 5;
            double actual = calc.Sum(2, 3);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SubtractsOneIntFromAnotherInt_ShouldOutputTheDifferenceOfTwoNumbers()
        {
            //Subtraction -
            int subtract = a - b;
        }
        [TestMethod]
        public void MultipliesOneIntByAnotherInt_ShouldOutputTheMultiplyOperatorOfTwoNumbers()
        {
            //Multiplication *
            int multiply = a * b;
        }
        [TestMethod]
        public void DividesOneIntByAnotherInt_ShouldOutputTheDivisionOperatorOfTwoNumbers()
        {
            //Division
            int divide = a / b;
        }
        [TestMethod]
        public void TestDifference_DoubleArrayOverload_ShouldAssertExpectedAndActualAreEqual()
        {
            double expected = 10d
            double actual = calc.Difference(100d, 50d, 40d)
        }



        }
    //AS MANY NUMBERS AS USER PROVIDES
    public double Difference(params double[] args)
    {
        double runningTotal = args[0];
            foreach (double arg in args)
            {
            runningTotal -= arg;
            }
            return runningTotal
        }
    }

