using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            //Foreach(1;2;3;4)
            //1:Değişken Türü 2: Değişken Adı 3: In(içinde anlamında) komutu 4: Liste,koleksiyon,dizi

            //string[] cities = { "Mardin", "Roma", "budapeşta", "ankara", "istanbul", "varşova" };
            //foreach (string sehirler in cities)
            //{
            //    Console.WriteLine(sehirler);
            //}

            //int[] numbers = { 47, 52, 34, 21, 55, 99, 98, 123, 654, 75, 22, 023, 33 };

            //foreach (int sayilar in numbers)
            //{
            //    Console.WriteLine(sayilar);
            //}

            //int[] numbers = { 47, 52, 34, 21, 55, 99, 98, 123, 654, 75, 22, 023, 33 };
            //foreach (int number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 47, 52, 34, 21, 55, 99, 98, 123, 654, 75, 22, 023, 33 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //foreach (int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //string word = "Mardin";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            #endregion
            #region Sınav Puan Hesaplama
            Console.WriteLine("-----------------Puan Hesaplama----------------");
            //Öğrensı sayısını kullanıcıdan alma
            Console.Write("Sınıftakaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            //Öğrenci ismi ve not ortalaması
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                //Her öğrenci için 3 sınav not girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;//notları topluyor
                }
                Console.WriteLine("-----------------------------------------------");
                studentExamAvg[i] = totalExamResult / 3;
            }
            //sınav ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //dersten geçme durumu
                if (studentExamAvg[i] >= 50)
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten geçti.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("-----------------------------------------------");

                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("-----------------------------------------------");
                }
            }

            #endregion

            Console.Read();
        }
    }
}