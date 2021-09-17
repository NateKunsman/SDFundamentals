using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            //Declaring a variable
            bool isDeclared;

            //Initializing a variable
            isDeclared=true;

            //Using camelCase for variables
            bool isDeclaredAndInitialized = true;

            isDeclaredAndInitialized = false;
        }
        [TestMethod]
        public void Chararcters()
        {
            //To define a character use single quotes.
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char specialCharacter = '\n';
        }
        [TestMethod]
        public void WholeNumbers()
        {
            //int, short, byte, long, int16, int32, int64
            //2^8
            byte byteExample = 255;
            sbyte sByteExample = -128;

            //2 ^ 16
            short shortExample = 32767;
            Int16 anotherShortExample = -32768;

            //2^32
            int intMax = 2147483647;
            Int32 intMin = -2147483648;
            uint inSignedInt = 2147483648;


            //2^64
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

        }

        [TestMethod]
        public void Decimals()
        {
            //decimal, double, float
            float floatExample = 1.9238575f;
            double doubleExample = 1.9238575d;
            decimal decimalExample = 881.123981359816598169838m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        //Enum
        enum PastryTypes { Donuts, Cake, Cupcakes, Pie}
        [TestMethod]
        public void Enums() 
        {
            PastryTypes myPastry = PastryTypes.Cake;
            PastryTypes anotherOne = PastryTypes.Donuts;

        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;

            DateTime today = DateTime.Today;

            DateTime specificDate = new DateTime(2021, 9, 14);

            DateTime todayTwo = today;


            //var takes its type from the right side of the assignment operator
            var variable = 32;              
                                                            
        }

    }
}
