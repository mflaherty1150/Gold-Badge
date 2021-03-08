using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables2
{
    [TestClass]
    public class ValueTypeExamples
    {
        [TestMethod]
        public void Booleans()
        {
            // Here is a declared variable
            bool isDeclared;

            // Now we've called our variable let's assign a value
            isDeclared = true;

            bool isDeclaredAlso = false;
            isDeclaredAlso = true;
        }

        [TestMethod]
        public void Characters()
        {
            // To define a single character, make sure to use single quotes ('')
            char character = 'a';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumber()
        {
            //Here we just have a lot of whole number
            byte byteExample = 255;
            sbyte sByteMax = -128;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            int a = 15;
            int b = -10;

            byte age = 42;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.034532f;
            double doubleExample = 1.450983450923345d;
            decimal decimalExample = 1.2342353465767456745633456m;

            Console.WriteLine(1.25789072890457897897897897897897f);
            Console.WriteLine(1.25789072890457897897897897897897d);
            Console.WriteLine(1.25789072890457897897897897897897m);
        }
        
        enum PastryType { Cake=1, Cupcake, Eclaire, Petifour, Croissant };

        [TestMethod]
        public void Enums()
        {
            // Now that we have an enum declared above, we can create variables of that new type
            PastryType myPastry = PastryType.Croissant;
            PastryType anotherOne = PastryType.Cake;
            Console.WriteLine(myPastry);
            Console.WriteLine(anotherOne);
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            DateTime birthday = new DateTime(1999, 2, 11);
            Console.WriteLine(today);
            Console.WriteLine(birthday);
            TimeSpan daysOld = today - birthday;
            Console.WriteLine(daysOld);
        }
    }
}
