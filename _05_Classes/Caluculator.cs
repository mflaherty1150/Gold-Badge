using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Caluculator
    {
        // Add
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public float Add(float floatOne, float floatTwo)
        {
            float sum = floatOne + floatTwo;
            return sum;
        }

        public int Subtract(int subOne, int subTwo)
        {
            int difference = subOne - subTwo;
            return difference;
        }

        public int Product(int productOne, int productTwo)
        {
            int product = productOne * productTwo;
            return product;
        }

        public decimal Divide(int numOne, int numTwo)
        {
            decimal quotient = numOne / numTwo;
            return quotient;
        }

        public int Remainder(int numOne, int numTwo)
        {
            int remainder = numOne % numTwo;
            return remainder;
        }

        public TimeSpan Remainder(DateTime bDay)
        {
            //DateTime now = DateTime.Now;
            //DateTime bDay = new DateTime(1985, 8, 16);
            DateTime now = DateTime.Now;

            TimeSpan difference = now - bDay;
            return difference;
        }
    }
}
