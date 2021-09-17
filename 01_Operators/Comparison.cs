using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _01_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int year = 2021;
            string name = "Nate";

            //Equal ==
            bool equel = year == 3000;
            bool isThisBob = name == "Bob";
            Console.WriteLine(equel);
            Console.WriteLine(isThisBob);

            //Inequality typed as !=

            bool notEqual = year != 2021;
            bool isNotBob = name != "Bob";
            Console.WriteLine(notEqual);
            Console.WriteLine(isNotBob);

            //Equality with regards to reference types
            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool listItemsAreEqual = firstList[0] == secondList[0];
            Console.WriteLine(listItemsAreEqual);

            //Greater
            bool twentyFirstCentury = year > 2000;

            //Less than
            bool lessThan = year < 3000;

            //Greater or equal
            bool greatOrEqual = year >= 2021;

            //Less or equal
            bool lessOrEqual = year <= 1990;

            bool trueValue = true;
            bool falseValue = false;

            // or ||
            bool tOrT = trueValue || trueValue; //true
            bool tOrF = trueValue || falseValue; //true
            bool fOrT = falseValue || trueValue; //true
            bool fOrF = falseValue || falseValue; //false

            //And typed as "&&"

            bool tAndT = trueValue && trueValue; //true
            bool tAndF = trueValue && falseValue; //false
            bool fAndT = falseValue && trueValue; //false
            bool fAndF = falseValue && falseValue; //false

        }
    }
}
