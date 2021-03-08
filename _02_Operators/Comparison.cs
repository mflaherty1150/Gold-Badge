using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 42;
            string username = "Marty";
            
            bool equals = (age == 50);
            bool userIsNick = username == "Nick";
            Console.WriteLine("User is 50: " + equals);
            Console.WriteLine("User is Nick: " + userIsNick);

            bool notEqual = age != 100;
            bool userIsNotJenna = username != "Jenna";
            Console.WriteLine("User is not 100: " + notEqual);
            Console.WriteLine("User is not Jenna: " + userIsNotJenna);

            List<string> firstList = new List<string>();
            firstList.Add(username);

            List<string> secondList = new List<string>();
            secondList.Add(username);

            bool listsAreEqual = (firstList == secondList);
            Console.WriteLine($"The lists are the same: {listsAreEqual}");

            bool greaterThan = (age > 12);
            bool lessThan = (age < 30);
            bool greaterThanOrEqual = (age >= 42);
            bool lessThanOrEqual = (age <= 55);

            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");

            bool andValue = (greaterThan && orValue);
        }
    }
}
