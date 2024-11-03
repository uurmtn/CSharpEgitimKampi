using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("selam mars");
            //Console.WriteLine("Selam");
            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Anayemekler");
            //Console.WriteLine("3- Ana Yemekler");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçeçekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion
            #region String Değişkenler
            //string Değişken_türü değişken_adı;
            //string name;
            //name = "ugur";
            //Console.WriteLine(name);

            //string customerName;//camelCase
            //string customerSurname;
            //string customerEmail;
            //string customerPhone, customerCity, district;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerEmail = "deneme@deneme.com";
            //customerPhone = "0555 444 33 22";
            //customerCity = "İstanbul";
            //district = "Kadıköy";

            //Console.WriteLine("***** Rezervasyon Kartı *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri: "+ customerName+" "+ customerSurname);
            //Console.WriteLine("İletişim: "+ customerPhone);
            //Console.WriteLine("Email Adresi:"+ customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------------");

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerEmail = "deneme1@deneme.com";
            //customerPhone = "0333 000 11 22";
            //customerCity = "Sakarya";
            //district = "Sapanca";
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi:" + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + customerCity);
            //Console.WriteLine("----------------------------------------------------");
            #endregion
            #region Int Değişkenler
            int number = 47;
            Console.WriteLine(number);
            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;


            Console.WriteLine("***** Restorant Menü Fiyat Listesi *****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("------Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("------Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine("------Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("------Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("------Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("***** Restorant Menü Fiyat Listesi *****");
            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;
            int totalPrice = 0;

            hamburgerCount = 2;
            cokeCount = 0;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 1;
            lemonadeCount = 2;

            totalPrice =
                hamburgerCount * hamburgerPrice +
                cokeCount * cokePrice +
                waterCount * waterPrice +
                friesCount * friesPrice +
                pizzaCount * pizzaPrice +
                lemonadeCount * lemonadePrice;

            Console.WriteLine("***** Sipariş Fişi *****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Hamburger " + hamburgerCount + " Adet " + hamburgerCount * hamburgerPrice + " TL");
            Console.WriteLine("Kola " + cokeCount + " Adet " + cokeCount * cokePrice + " TL");
            Console.WriteLine("Su " + waterCount + " Adet " + waterCount * waterPrice + " TL");
            Console.WriteLine("Kızartma " + friesCount + " Adet " + friesCount * friesPrice + " TL");
            Console.WriteLine("Pizza " + pizzaCount + " Adet " + pizzaCount * pizzaPrice + " TL");
            Console.WriteLine("Limonata " + lemonadeCount + " Adet " + lemonadeCount * lemonadePrice + " TL");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            #endregion



            Console.Read();
        }
    }
}