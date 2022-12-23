using Ischuk.lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab6
{
    internal class Case7
    {
        private const string _test = "Строка 1:\r\nВаркалось. Хливкие шорьки Пырялись по наве, И хрюкотали зелюки, Как мюмзики в мове.\r\nО бойся Бармаглота, сын! Он так свирлеп и дик, А в глуще рымит исполин - Злопастный Брандашмыг.";
        private const string _test1 = "Быть может, вся Природа – мозаика цветов?";
        private const string _test2 = "Быть может, вся Природа – различность голосов?";
        private string test;
        private string test1;
        private string test2;
        public Case7()
        {
            test = _test;
            test1 = _test1;
            test2 = _test2;
        }
        public Case7(string test,string test1,string test2)
        {
            this.test = test;
            this.test1 = test1;
            this.test2 = test2;
        }



        public string ManString()
        {
            Console.WriteLine("Введите строку");
            string _Manual = Console.ReadLine();
            return _Manual;
        }

        public void VowCon()
        {
            Console.WriteLine("Строка: " + test);
            int Count1 = 0;
            int Count2 = 0;
            string vowels = "АЕЁИОУЫЭЮЯаеёиоуыэюя";
            string consonants = "БВГДЖЗЙКЛМНПРСТФХЦЧШЩбвгджзйклмнпрстфхцчшщ";
            for (int i = 0; i < test.Length; i++)
            {
                if (vowels.Contains(test[i]))
                {
                    Count1++;
                }
                else if (consonants.Contains(test[i]))
                {
                    Count2++;
                }

            }
            Console.WriteLine("Гласных: " + Count1);
            Console.WriteLine("Согласных: " + Count2);
        }
        public void Acount()
        {
            Console.WriteLine("Строка: " + test);
            int Count1 = 0;
            int Count2 = 0;
            string a = "аА";
            for (int i = 0; i < test.Length; i++)
            {
                if (a.Contains(test[i]))
                {
                    Count1++;
                }
                else
                    Count2++;

            }
            Console.WriteLine("Знаков A(a): " + Count1);
        }
        public void EqualString()
        {
            Console.WriteLine("Строка1: " + test1);
            Console.WriteLine("Строка2: " + test2);

            int Count1 = 0;
            int length = 0;
            if (test1.Length > test2.Length)
            {
                length = test2.Length;
            }
            else
            {
                length = test1.Length;
            }
            for (int i = 0; i < length; i++)
            {
                if (test1[i] == test2[i])
                {
                    Count1++;
                }
                else
                    i = test1.Length;
            }
            Console.WriteLine("Знаков Совпадает: " + Count1);
        }
    }
}
