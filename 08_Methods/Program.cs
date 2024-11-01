using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void & Parameterless Methods

            //void CustomerList()
            //{
            //    Console.WriteLine("Customer One");
            //    Console.WriteLine("Customer Two");
            //    Console.WriteLine("Customer Three");
            //    Console.WriteLine("Customer Four");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Void & String Parameterized Methods

            //void WriteCustomer(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteCustomer("Customer One");

            //void CustomerCard(string firstName, string lastName)
            //{
            //    Console.WriteLine("Customer : " + firstName + " " + lastName);
            //}

            //CustomerCard("John", "Marshall");
            //CustomerCard("Jane", "Koopmeiners");

            #endregion

            #region Void & Integer Parameterized Methods

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}

            //Sum(12, 4, 79);

            #endregion

            #region Methods with Return Type & Parameterless

            //string GetCustomerName()
            //{
            //    return "John Marshall";
            //}

            //GetCustomerName();


            //string StudentCard()
            //{
            //    string studentName = "Enzo";
            //    string studentSurname = "Ferrari";

            //    return studentName + " " + studentSurname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Methods with Return Type & String Parameterized

            //string CountryCard(string countryName, string capitalCity, string flagColour)
            //{
            //    string cardInfo = "Country Name : " + countryName + " Capital City : " + capitalCity + " Flag Colour : " + flagColour;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.WriteLine("Enter Country Name: ");
            //x = Console.ReadLine();

            //Console.WriteLine("Enter Capital City: ");
            //y = Console.ReadLine();

            //Console.WriteLine("Enter Flag Colour: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine("Italy", "Rome", "Green, White, Red");

            #endregion

            #region Methods with Return Type & Integer Parameterized

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(12, 4));
            //Console.WriteLine(Sum(25, 43));
            //Console.WriteLine(Sum(66, 666));
            //Console.WriteLine(Sum(38, 77));

            #endregion

            #region Example Application

            string examResult(string student, int exam1, int exam2, int exam3)
            {
                int average = (exam1 + exam2 + exam3) / 3;

                if (average >= 50)
                {
                    return student + " Passed and the semester result is :" + average;
                }
                else
                {
                    return student + " Failedand the semester result is :" + average;
                }
            }

            Console.WriteLine(examResult("John", 45, 55, 65));
            Console.WriteLine(examResult("Jane", 75, 85, 95));
            Console.WriteLine(examResult("Jack", 25, 35, 45));
            Console.WriteLine(examResult("Jill", 55, 65, 75));

            #endregion

            Console.Read();
        }
    }
}
