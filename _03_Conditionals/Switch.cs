using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Conditionals
{
    [TestClass]
    public class Switch
    {
        enum WeekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };

        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;

            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");
                    break;
                case 2:
                    Console.WriteLine("What you doing?");
                    break;
                default:
                    Console.WriteLine("This is the default. It will execute if no other case evaluates to true. Defaults are not required.");
                    break;
            }

            WeekDay today = WeekDay.Tuesday;

            switch (today)
            {
                case WeekDay.Monday:
                case WeekDay.Tuesday:
                case WeekDay.Wednesday:
                case WeekDay.Thursday:
                case WeekDay.Friday:
                    Console.WriteLine("Hope you're ready to work!");
                    break;
                case WeekDay.Saturday:
                case WeekDay.Sunday:
                    Console.WriteLine("Sorry we're closed");
                    break;
            }
        }
    }
}
