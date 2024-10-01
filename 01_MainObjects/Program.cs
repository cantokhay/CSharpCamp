using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma İşlemleri

            //Console.Write("Merhaba Dünya!");
            //Console.WriteLine("Çıkak için bir tuşa basınız...");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1. Tatlılar");
            //Console.WriteLine("2. Başlangıçlar");
            //Console.WriteLine("3. Ana Yemekler");
            //Console.WriteLine("4. Çorbalar");
            //Console.WriteLine("5. Salatalar");
            //Console.WriteLine("6. İçecekler");
            //Console.WriteLine();

            #endregion

            #region String Değişkenler

            //string name;
            //name = "Can";
            //Console.WriteLine(name);

            string passengerName;
            string passengerSurname;
            string passengerPhone;
            string passengerEmail, district, city;
            passengerName = "Can";
            passengerSurname = "Tokhay";
            passengerPhone = "0532 123 45 67";
            passengerEmail = "test@test.com";
            district = "Çankaya";
            city = "Ankara";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Müşteri Adı:" + " " + passengerName + " " + passengerSurname);
            Console.WriteLine("Telefon:" + " " + passengerPhone);
            Console.WriteLine("E-Posta:" + " " + passengerEmail);
            Console.WriteLine("Adres:" + " " + district + "/" + city);
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();

            passengerName = "Ali";
            passengerSurname = "Veli";
            passengerEmail = "gmail@gmail.com";
            passengerPhone = "0555 555 55 55";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("Müşteri Adı:" + " " + passengerName + " " + passengerSurname);
            Console.WriteLine("Telefon:" + " " + passengerPhone);
            Console.WriteLine("E-Posta:" + " " + passengerEmail);
            Console.WriteLine("Adres:" + " " + district + "/" + city);
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();

            #endregion

            #region Sayısal Değişkenler

            //int number = 33;
            //Console.WriteLine(number);

            int hamburgerPrice = 15;
            int colaPrice = 5;
            int waterPrice = 2;
            int friesPrice = 7;
            int pizzaPrice = 20;
            int lemonadePrice = 3;

            Console.WriteLine("**** Menü Listesi ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger:" + hamburgerPrice + "$");
            Console.WriteLine("-----Pizza:" + pizzaPrice + "$");
            Console.WriteLine("-----Kola:" + colaPrice + "$");
            Console.WriteLine("-----Limonata:" + lemonadePrice + "$");
            Console.WriteLine("-----Kızartma:" + friesPrice + "$");
            Console.WriteLine("-----Su:" + waterPrice + "$");
            Console.WriteLine();
            Console.WriteLine("**** Menü Listesi ****");
            Console.WriteLine();

            int hamburgerCount = 2;
            int pizzaCount = 0;
            int colaCount = 1;
            int lemonadeCount = 0;
            int friesCount = 1;
            int waterCount = 4;

            int totalHamburgerPrice = 0;
            int totalPizzaPrice = 0;
            int totalColaPrice = 0;
            int totalLemonadePrice = 0;
            int totalFriesPrice = 0;
            int totalWaterPrice = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalColaPrice = colaPrice * colaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;
            totalFriesPrice = friesPrice * friesCount;
            totalWaterPrice = waterPrice * waterCount;
            totalPizzaPrice = pizzaPrice * pizzaCount;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Hamburger Toplam Fiyatı:" + totalHamburgerPrice + "$");
            Console.WriteLine("Pizza Toplam Fiyatı:" + totalPizzaPrice + "$");
            Console.WriteLine("Kola Toplam Fiyatı:" + totalColaPrice + "$");
            Console.WriteLine("Limonata Toplam Fiyatı:" + totalLemonadePrice + "$");
            Console.WriteLine("Kızartma Toplam Fiyatı:" + totalFriesPrice + "$");
            Console.WriteLine("Su Toplam Fiyatı:" + totalWaterPrice + "$");

            Console.WriteLine();

            int Gram = totalHamburgerPrice + totalPizzaPrice + totalColaPrice + totalLemonadePrice + totalFriesPrice + totalWaterPrice;
            Console.WriteLine("Toplam Hesap:" + Gram + "$");
            Console.WriteLine("-------------------------------------------------");


            #endregion

            Console.Read();
        }
    }
}
