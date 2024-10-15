using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DecisionMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF

            //Console.Write("Please Enter Your Password: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Correct Password");
            //}
            //else
            //{
            //    Console.WriteLine("WrongPassword Please Try Again!");
            //}


            //string capitalCity, capitalCountry;
            //Console.Write("Please Enter a City: ");
            //capitalCity = Console.ReadLine();

            //Console.Write("Please Enter a Country: ");
            //capitalCountry = Console.ReadLine();

            //if(capitalCity == "ankara" & capitalCountry == "türkiye")
            //{
            //    Console.WriteLine("Aprroved!");
            //}
            //else
            //{
            //    Console.WriteLine("Not Approved!");
            //}


            //int number;
            //Console.WriteLine("Enter a Number: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Correct Number!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number! ");
            //}


            //int examResult1, examResult2, examResult3, average;
            //string semesterResult = "Hata!";

            //Console.WriteLine("First Exam Result: ");
            //examResult1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Second Exam Result: ");
            //examResult2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Final Exam Result: ");
            //examResult3 = int.Parse(Console.ReadLine());

            //average = (examResult1 + examResult2 + examResult3) / 3;
            //Console.WriteLine("Average Point: " + average);

            //if (average > 0 & average <= 35)
            //{
            //    semesterResult = "F";
            //}
            //if (average > 35 & average <= 50)
            //{
            //    semesterResult = "D";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    semesterResult = "C";
            //}
            //if (average > 84 & average <= 94)
            //{
            //    semesterResult = "B";
            //}
            //if(average > 94)
            //{
            //    semesterResult = "A";
            //}

            //Console.WriteLine(semesterResult);


            //string city;
            //Console.WriteLine("Please Enter a City");
            //city = Console.ReadLine();

            //if(city == "adana" | city == "ankara" | city == "bursa" |city == "samsun")
            //{
            //    Console.WriteLine("Valid City");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}


            //string userName;
            //Console.WriteLine("Please Enter Your User Name");
            //userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.WriteLine("No Permission");
            //}
            //else
            //{
            //    Console.WriteLine("Hello Admin");
            //}

            #endregion

            #region Mod Calculations

            //int number;
            //number = 28;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("Please Enter First Number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please Enter Second Number");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("First number to mod second number is: ");

            //Console.Write("Please enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Even Number");
            //}
            //else
            //{
            //    Console.Write("Odd Number");
            //}

            #endregion

            #region Char

            char team;

            Console.WriteLine("Please enter team symbol");
            team = char.Parse(Console.ReadLine());

            if (team == 'g' | team == 'G')
            {
                Console.WriteLine("Galatasaray");
            }

            if (team == 'f' | team == 'F')
            {
                Console.WriteLine("Fenerbahçe");
            }

            if (team == 'a' | team == 'A')
            {
                Console.WriteLine("Ankaragücü");
            }

            #endregion

            #region Restaurant Menu Project Example

            //Console.WriteLine("***** Camp Restaurant");
            //Console.WriteLine();
            //Console.WriteLine("*-------------------------------------*");
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Stews");
            //Console.WriteLine("3-Pizzas");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine("*-------------------------------------*");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine();
            //Console.Write("Select for Details: ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*---------------Soups-------------*");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Vegetable Soup");
            //    Console.WriteLine("2-Chicken Soup");
            //    Console.WriteLine("3-Lentil Soup");
            //    Console.WriteLine("*---------------Soups-------------*");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*---------------Stews-------------*");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Chicken Stew");
            //    Console.WriteLine("2-Lamb Stew");
            //    Console.WriteLine("*---------------Stews-------------*");
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*---------------Pizzas-------------*");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margherita Pizza");
            //    Console.WriteLine("2-Pepperoni Pizza");
            //    Console.WriteLine("3-BBQ Chicken Pizza");
            //    Console.WriteLine("*---------------Pizzas-------------*");
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*---------------Drinks-------------*");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Coke");
            //    Console.WriteLine("2-Pepsi");
            //    Console.WriteLine("3-Mt Dew");
            //    Console.WriteLine("4-Water");
            //    Console.WriteLine("5-Sprinkle Water");
            //    Console.WriteLine("*---------------Drinks-------------*");
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("*---------------Desserts-------------*");
            //    Console.WriteLine();
            //    Console.WriteLine("1-San Sebastian");
            //    Console.WriteLine("2-Lemon Cheesecake");
            //    Console.WriteLine("3-Profiterole");
            //    Console.WriteLine("4-Mosaic Cake");
            //    Console.WriteLine("*---------------Desserts-------------*");
            //}

            #endregion

            #region Switch-Case

            Console.WriteLine("Please Enter Month: ");
            int monthNumber = int.Parse(Console.ReadLine());

            switch (monthNumber)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("Fabruary"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("Sebtember"); break;
                case 10: Console.WriteLine("October"); break;
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
                default: Console.WriteLine("Error Occured"); break;
            }

            #endregion

            #region Calculator App

            int number1, number2, result;
            char symbol;

            Console.WriteLine("Enter Number1: ");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number2: ");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter mathematical Symbol: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.Write("Result is: "); break;

                case '-':
                    result = number1 - number2;
                    Console.Write("Result is: "); break;

                case '*':
                    result = number1 * number2;
                    Console.Write("Result is: "); break;

                case '/':
                    result = number1 / number2;
                    Console.Write("Result is: "); break;
            }

            #endregion

            Console.Read();
        }
    }
}
