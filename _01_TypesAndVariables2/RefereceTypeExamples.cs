using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_TypesAndVariables2
{
    [TestClass]
    public class RefereceTypeExamples
    {
        [TestMethod]
        public void Strings()
        {
            // Like other types we can simply declare a variable of the string type
            string thisIsDeclaration;

            // We can also declare and then later initialize a value
            string declared;
            declared = "This is initialized.";

            // Declare and initialize together
            string declareAndInitialize = "Doing them both together!";

            string firstName = "Marty";
            string lastName = "Flaherty";

            string concatenatedName = firstName + " " + lastName;

            string compositeFullName = string.Format("Hello Mr/Mrs {0} {1}", firstName, lastName);

            string interpolatedFullName = $"Hello Mr/Mrs {firstName} {lastName}, here is more text to read.";
        }

        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello world!";

            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample, "?" };
            string thirdItem = stringArray[2];
            stringArray[0] = "Hey there";

            List<string> listOfStrings = new List<string>();
            List<int> listOfIntegers = new List<int>();
            listOfStrings.Add("First string for our list!");
            listOfIntegers.Add(46060);

            Queue<string> firstInFirstOut = new Queue<string>();
            firstInFirstOut.Enqueue("I'm first in line!");
            firstInFirstOut.Enqueue("I'm next.");

            string name = firstInFirstOut.Dequeue();

            int x = 2;

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(7, "Agent");
            keyAndValue.Add(1, "CEO");
            keyAndValue.Add(2, "Owner");
            keyAndValue.Add(18, "Customer");

            string valueSeven = keyAndValue[7];
            string valueTwo = keyAndValue[x];

            // Other Collection Types
            SortedList<int, string> sortedKeyAndValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
        }
    }
}
