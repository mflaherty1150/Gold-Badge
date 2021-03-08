using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Loops
{
    [TestClass]
    public class LoopExamples
    {
        [TestMethod]
        public void WhileLoops()
        {
            int total = 1;

            while (total != 10)
            {
                Console.WriteLine(total);
                total++;
            }

            total = 0;

            while (true)
            {
               if (total == 10)
                {
                    Console.WriteLine("Goal reached!");
                    break;
                }
                total++;
            }

            Random rand = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {
                someCount = rand.Next(0, 20);
                if (someCount == 6 || someCount == 10)
                {
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }
        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            for(int i=0; i < studentCount; i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Nick", "Adam", "Greg", "Nathan", "Karina", "Danny", "Jacob" };

            for (int i=0; i < students.Length; i++)
            {
                Console.WriteLine($"Welcome to class {students[i]}!");
            }
        }

        [TestMethod]
        public void ForeachLoops()
        {
            string[] students = { "Nick", "Adam", "Greg", "Nathan", "Karina", "Danny", "Jacob" };

            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in this class.");
            }

            string myName = "Marty Flaherty";
            foreach(char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int iterator = 0;
            do
            {
                Console.WriteLine("Hello!");
                iterator++;
            }
            while (iterator < 5);

            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);

            while (false)
            {
                Console.WriteLine("My while condition is false!");
            }
        }
    }
}
