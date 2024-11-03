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
            #region Temel Dizi Örnekleri
            //DeğişkenTürü [] DiziAdı=new değişkenTürü[ElemanSayısı]
            //string[] colors = new string[5];
            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Kahire";
            //cities[2] = "Üsküp";
            //cities[3] = "Budapeşta";
            //cities[4] = "Lyon";
            //Console.WriteLine(cities[5]);

            //int[] numbers = new int[10];
            //numbers[0] = 47;
            //numbers[1] = 147;
            //numbers[3] = 047;
            //numbers[5] = 50;
            //numbers[7] = 21;
            //Console.WriteLine(numbers[7]);

            //string[] cities = { "Prag", "Mardin", "İstanbul", "Atina", };
            //Console.WriteLine(cities[2]);

            #endregion
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = {"Kırmızı","Sarı","Beyaz","Yeşil","Mavi","Turuncu","Mor"};
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4,5,9,7,21,3,65,47,477,65,32,15,65,98,22,33,321,03};
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }   
            //}

            //char[] symbols = { 'a', 'b', 'c', '*','-','/' };
            //for(int i=0; i<symbols.Length;i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] arraysNum = {47,55,52,85,125,365,10,55,1236};
            //int maxNum = arraysNum[0];
            //for(int i=0;i<arraysNum.Length;i++)
            //{
            //    if (arraysNum[i]>maxNum)
            //    {
            //        maxNum = arraysNum[i];
            //    }
            //}
            //Console.WriteLine(maxNum);

            //string[] persons = { "ali", "ahmet", "buse", "cem", "muhittin" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 2, 5, 66, 84, 1, 12, 35, 65, 47, 13 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 2, 5, 66, 84, 1, 12, 35, 65, 47, 13 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion
            #region Dizi Metotları
            //string[] customers = {"ahmo","ayşo","cino", "maho","selo","hemo"};
            //int index = Array.IndexOf(customers, "maho");
            //Console.WriteLine(index);

            //int[] num = { 12,23,5475,6578,234,1235,55,98,74};
            //Console.WriteLine("Dizideki en büyük eleman: "+num.Max()+" En küçük eleman: "+num.Min());

            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine("----------------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] num = { 10, 20, 30, 40, 50, 60, 70, 80 };
            //int sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //Console.WriteLine(sum);

            int[] num = { 32, 56, 99, 84, 3211, 68, 62, 31, 47, 699, 3, 22, 20, 25, 55, 56, 96 };
            Array.Sort(num);
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 1)
                {
                    Console.WriteLine(num[i]);
                }
            }

            #endregion

            Console.Read();
        }
    }
}