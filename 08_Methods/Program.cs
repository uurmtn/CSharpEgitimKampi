using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //ikiye ayrılır geriye değer döndüren ve döndürmeyen.
            //Void geriye değer döndürmez
            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Çınar");
            //    Console.WriteLine("Mahmut Alver");
            //}
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

            #region Parametreli değer döndürmeyen metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Uğur");

            //void CustomerCard(string name, string surname)//String
            //{
            //    Console.WriteLine("Müşteri: "+ name+" "+surname);
            //}

            //CustomerCard("Uğur","Metin");
            //CustomerCard("Metin", "Uğur");

            //void Sum(int num1, int num2,int num3)
            //{ 
            //    int result=num1+ num2+num3 ;
            //    Console.WriteLine(result);
            //}
            //Sum(2,3,4);
            #endregion

            #region Geriye değer döndüren metotlar (Parametresiz)
            //string CustomerCard(string CustomerName)
            //{
            //    return "Buse";
            //}

            //string StundetCard()
            //{
            //    string name = "Uğur";
            //    string surName = "Metin";
            //    return name+" "+surName;
            //}
            //Console.WriteLine(StundetCard());
            #endregion

            #region Geriye değer döndüren metotlar (Parametreli)
            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke ismi giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak Rengi: ");
            //z = Console.ReadLine();

            //Console.WriteLine( CountryCard(x, y, z));
            #endregion

            #region Geriye int değer döndüren metotlar (Parametreli)

            //int Sum(int num1,int num2)
            //{
            //    int result=num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(1,4));
            //Console.WriteLine(Sum(13,45));
            //Console.WriteLine(Sum(11,84));
            //Console.WriteLine(Sum(81,43));

            #endregion

            #region Örnek

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. " + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavı geçemedi. " + "Ortalama: " + result;
                }

            }
            Console.WriteLine(ExamResult("Uğur", 56, 98, 65));
            Console.WriteLine(ExamResult("Metin", 55, 12, 31));
            #endregion

            Console.Read();
        }
    }
}