using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Loops

            //Syntax: For(x,y,z)
            //x: Initialization
            //y: Condition
            //z: Increment/Decrement

            //int i;
            //for (i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("Please enter loop times: ");
            //int loopTimes = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < loopTimes; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region For Loop and Decisions

            //for (int i = 0; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //int total = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //int total = 0;
            //for (int i = 0; i<20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        total += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------");
            //Console.WriteLine("total: " + total);


            //int counter = 0;
            //for (int i = 1; i <= 60; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        counter++;
            //    }
            //}
            //Console.WriteLine(counter);

            #endregion

            #region Bacteria Fertilization Example

            int bacterium = 1;

            for (int i = 0; i <= 24; i++)
            {
                bacterium *= 2;
                Console.WriteLine("At the end of " + i + "hour(s), total bacteria count: " + bacterium);
            }

            #endregion

            #region While Loop

            //syntax: while(condition)
            //{ operations }

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}


            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;
            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine("Sum: " + sum);




            #endregion

            #region Quiz Question
            //Write codes that sums the digits of a three-digit number entered from the keyboard

            Console.WriteLine("Please enter a three-digit number: ");
            int number = int.Parse(Console.ReadLine());

            int sum, ones, tens, hundreds;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;

            sum = ones + tens + hundreds;

            Console.WriteLine("Digits: " + hundreds + "-" + tens + "-" + ones);
            Console.WriteLine("Sum of the digits: " + sum);

            #endregion

            Console.Read();
        }
    }
}
