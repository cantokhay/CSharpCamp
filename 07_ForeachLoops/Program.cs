using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach

            //syntax
            //foreach (var item in collection)
            //{ operations }

            //string[] cities = { "New York", "London", "Mumbai", "Chicago" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}


            //int[] numbers = { 123, 456, 789, 101, 202, 303, 404, 505, 606, 707, 808 };

            //foreach (int x in numbers)
            //{
            //    Console.WriteLine(x);
            //}

            //foreach (int x in numbers)
            //{
            //    if (x % 2 == 0)
            //    {
            //        Console.WriteLine(x);
            //    }
            //}

            //int total = 0;

            //foreach (int x in numbers)
            //{
            //    total += x;
            //}

            //Console.WriteLine("Total: " + total);


            //List<int> numbersList = new List<int>()
            //{
            //    1,2,3,4,7,8
            //};

            //foreach (int x in numbersList)
            //{
            //    Console.WriteLine(x);
            //}

            //string word = "Hello World";

            //foreach (char x in word)
            //{
            //    Console.WriteLine(x);
            //}


            #endregion

            #region Exam System App Example

            Console.WriteLine("***** C Sharp Egitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("How many students in your class: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i + 1}. Student Name: ");
                studentNames[i] = Console.ReadLine();

                double totalGrade = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentNames[i]} - {j + 1}. Exam Grade: ");
                    double grade = double.Parse(Console.ReadLine());
                    totalGrade += grade;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalGrade / 3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Student Name: {studentNames[i]} - Grade: {studentExamAvg[i]}");

                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine("Passed");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
                Console.WriteLine("-----------------------------");
            }



            #endregion
        }
    }
}
