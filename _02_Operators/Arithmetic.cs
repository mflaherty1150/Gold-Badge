using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Operators
{
    [TestClass]
    public class Arithmetic
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            // Addition +
            int sum = a + b;
            Console.WriteLine(sum);

            // Subtraction - 
            int difference = a - b;
            Console.WriteLine(difference);

            // Multiplication *
            int product = a * b;
            Console.WriteLine(product);

            // Division /
            int quotient = a / b;
            Console.WriteLine(quotient);

            // Remainer %
            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            DateTime someDay = new DateTime(2000, 8, 29);

            TimeSpan timeSpan = now - someDay;
            Console.WriteLine(timeSpan);
        }
    }
}
