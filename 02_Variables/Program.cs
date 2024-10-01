using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            //double number = 2.52;

            //Console.WriteLine(number);

            Console.WriteLine("Fiyat Listesi: ");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 2.52;
            orangePrice = 3.56;
            strawberryPrice = 4.45;
            potatoPrice = 1.95;
            tomatoPrice = 2.67;

            Console.WriteLine("-----Elma: " + applePrice + "$");
            Console.WriteLine("-----Portakal: " + orangePrice + "$");
            Console.WriteLine("-----Çilek: " + strawberryPrice + "$");
            Console.WriteLine("-----Patates: " + potatoPrice + "$");
            Console.WriteLine("-----Domates: " + tomatoPrice + "$");
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            appleGram = 6.895;
            orangeGram = 10.689;
            strawberryGram = 5.789;
            potatoGram = 2.895;
            tomatoGram = 3.895;

            double appleTotal, orangeTotal, strawberryTotal, potatoTotal, tomatoTotal;
            appleTotal = applePrice * appleGram;
            orangeTotal = orangePrice * orangeGram;
            strawberryTotal = strawberryPrice * strawberryGram;
            potatoTotal = potatoPrice * potatoGram;
            tomatoTotal = tomatoPrice * tomatoGram;

            Console.WriteLine("Alınan Ürün: Elma - Birim Fiyatı: " + applePrice + " $" + " - Gramaj: " + appleGram + " - Toplam Elma Fiyatı : " + appleTotal +" $");
            Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyatı: " + orangePrice + " $" + " - Gramaj: " + orangeGram + " - Toplam Portakal Fiyatı : " + orangeTotal + " $");
            Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyatı: " + strawberryPrice + " $" + " - Gramaj: " + strawberryGram + " - Toplam Çilek Fiyatı : " + strawberryTotal + " $");
            Console.WriteLine("Alınan Ürün: Patates - Birim Fiyatı: " + potatoPrice + " $" + " - Gramaj: " + potatoGram + " - Toplam Patates Fiyatı : " + potatoTotal + " $");
            Console.WriteLine("Alınan Ürün: Domates - Birim Fiyatı: " + tomatoPrice + " $" + " - Gramaj: " + tomatoGram + " - Toplam Domates Fiyatı : " + tomatoTotal + " $");
            Console.WriteLine();

            double shoppingTotal = appleTotal + orangeTotal + strawberryTotal + potatoTotal + tomatoTotal;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Toplam Alışveriş Tutarı: " + shoppingTotal + " $");

            #endregion

            #region Char Variables
            char symbol;
            symbol = 'a';
            Console.WriteLine("Karakter: " + symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            Console.WriteLine("CHY Müşteri Bilgileri : ");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict , passengerCity, passengerAge, passengerIdentityNumber;

            Console.Write("Adınız: ");
            passengerName = Console.ReadLine();
            Console.Write("Soyadınız: ");
            passengerSurname = Console.ReadLine(); 
            Console.Write("İlçe: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yaşınız: ");
            passengerAge = Console.ReadLine();
            Console.Write("TC Kimlik Numaranız: ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine("-------------------");
            Console.WriteLine("TC Kimlik No: " + passengerIdentityNumber + " Ad Soyad: " + passengerName + " " + passengerSurname + " - İlçe: " + passengerDistrict + " - Şehir: " + passengerCity + " - Yaş: "+ passengerAge);

            #endregion

            #region Klavyeden Veri Girişleri Int Değişkenler ve Dönüşümler

            int shoePrice, computerPrice, tvPrice, chairPrice;

            shoePrice = 6150;
            computerPrice = 32500;
            tvPrice = 91500;
            chairPrice = 3200;

            int shoeCount, computerCount, tvCount, chairCount;

            Console.Write("Ayakkabı Adedini  Giriniz: ");
            shoeCount = int.Parse(Console.ReadLine());
            Console.Write("Bilgisayar Adedini  Giriniz: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Televizyon Adedini  Giriniz: ");
            tvCount = int.Parse(Console.ReadLine());
            Console.Write("Sandalye Adedini  Giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (tvPrice * tvCount) + (chairPrice * chairCount);

            Console.WriteLine();
            Console.WriteLine("Toplam Alışveriş Tutarı: " + totalPrice + " TL");

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            double exam1, exam2, exam3, result;

            Console.Write("1. Sınavı Sonucunu  Giriniz: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.Write("2. Sınavı Sonucunu  Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.Write("3. Sınavı Sonucunu  Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine();
            Console.WriteLine("Ortalama: " + result);

            #endregion

            #region Klavyeden Karakter Girişi

            char gender;

            Console.Write("Lütfen Cinsiyet Giriniz: ");

            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçilen Cİnsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
