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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = Encoding.UTF8;//Türkçe karakter kullanımı            
            #region Double Değişkenler

            //double number;
            //number=4.85;
            //Console.WriteLine(number);
            //Console.WriteLine("------------------------------------------------------------");            
            //Console.WriteLine("*****Fiyat Listesi *****");
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice =20.95;
            //strawberryPrice =45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("--> Elma Birim Fiyatı: "+applePrice+" ₺");
            //Console.WriteLine("--> Portakal Birim Fiyatı: "+ orangePrice + " ₺");
            //Console.WriteLine("--> Çilek Birim Fiyatı: "+ strawberryPrice + " ₺");
            //Console.WriteLine("--> Patates Birim Fiyatı: " + potatoPrice + " ₺");
            //Console.WriteLine("--> Domates Birim Fiyatı: " + tomatoPrice + " ₺");

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("Alınan Ürün: Elma - "+ "Birim Fiyat: "+applePrice+" - Gramaj: "+appleGram+" - Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - "+ "Birim Fiyat: "+orangePrice+" - Gramaj: "+orangeGram+" - Toplam Tutar: "+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - "+ "Birim Fiyat: "+strawberryPrice+" - Gramaj: "+strawberryGram+" - Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - "+ "Birim Fiyat: "+potatoPrice+" - Gramaj: "+potatoGram+" - Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - "+ "Birim Fiyat: "+tomatoPrice+" - Gramaj: "+tomatoGram+" - Toplam Tutar: "+tomatoTotalPrice);
            //double shoppingTotalPrice= appleTotalPrice+ orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+ potatoTotalPrice+ tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Alişveriş Toplam Tutar: "+shoppingTotalPrice+" ₺");

            #endregion
            #region Char Değişkenler
            //Console.WriteLine("------------------------------------------------------------");
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion
            #region Klavyeden Veri Girişi (String)
            //Console.WriteLine("------------------------------------------------------------");
            //Console.WriteLine("***** Uğur Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();
            //string passengerName,passengerSurname,passengerDistrict,passengerCity,passengerAge,passengerIdentityNumber;            
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.Clear();
            //Console.WriteLine("***** Uğur Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine("Kimlik Numarası: "+passengerIdentityNumber);
            //Console.WriteLine("Yolcu: " + passengerName + " " + passengerSurname);
            //Console.WriteLine("Şehir: "+passengerDistrict+"/"+passengerCity);
            //Console.WriteLine("Yaş: "+passengerAge);
            //Console.WriteLine("*-*-*-*-* İyi Uçuşlar Dileriz. *-*-*-*-*");
            #endregion
            #region Klavyeden Tam Sayı Girişi ve Dönüşümü
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz:  ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız bilgisayar sayısını giriniz:  ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız koltuk sayısını giriniz:  ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldığınız televizyon sayısını giriniz:  ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice=shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine("Toplam Ödeme Tutarı: "+totalPrice+" ₺");
            #endregion
            #region Ondalıklı sayı işlemleri
            //double exam1, exam2, exam3, result;
            //Console.Write("1. Sınav Notu: ");
            //exam1=double.Parse(Console.ReadLine());
            //Console.Write("2. Sınav Notu: ");
            //exam2 =double.Parse(Console.ReadLine());
            //Console.Write("3. Sınav Notu: ");
            //exam3 =double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalaması: "+ result);
            #endregion
            #region Karakter girişi
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz cinsiyet: "+gender);
            #endregion

            Console.Read();
        }
    }
}