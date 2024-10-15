using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple Array Examples

            //syntax
            //datatype[] arrayName = new datatype[size];

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Green";
            //colors[2] = "Blue";
            //colors[3] = "Yellow";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "New York";
            //cities[1] = "Los Angeles";
            //cities[2] = "Chicago";
            //cities[3] = "Houston";
            //cities[4] = "Phoenix";

            //Console.WriteLine(cities[5]); //gets an error

            //int[] numbers = new int[10];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[5] = 34;
            //numbers[8] = 45;
            //numbers[9] = 50;

            //Console.WriteLine(numbers[6]);

            //string[] cities = { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Array of Objects

            //string[] colors = { "Red", "Green", "Blue", "Yellow", "White", "Orange", "Pink", "Violet" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}


            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myArray = { 12, 45, 78, 96, 301, 23, 56, 78, 199 };

            //int maxNumber = myArray[0];

            //for (int i = 1; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);


            //string[] persons = { "John", "Jane", "Jack", "Jill", "Jonathan" };
            //Console.WriteLine(persons.Length);

            #endregion

            #region Array Built-In Methods

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 488, 522, 7456, 2365, 1120 };
            //string[] customers = { "John", "Jane", "Jack", "Jill", "Jonathan" };

            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int index = Array.IndexOf(customers, "Jack");
            //Console.WriteLine(index);

            //Console.WriteLine("Max of the array : " + numbers.Max() + "Min of the array : " + numbers.Min());

            #endregion

            #region User Input Array

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Enter {i + 1}. city name : ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            //int[] digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //Console.WriteLine("Even digits : ");

            //for (int i = 0; i < digits.Length; i++)
            //{
            //    if (digits[i] % 2 == 0)
            //    {
            //        Console.WriteLine(digits[i]);
            //    }
            //}

            //Console.WriteLine("--------------");
            //Console.WriteLine("Odd digits : ");

            //for (int i = 0; i < digits.Length; i++)
            //{
            //    if (digits[i] % 2 == 1)
            //    {
            //        Console.WriteLine(digits[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
