using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab5
{
    static class ReadNumbers
    {
        public static double ReadNumber()
        {
            bool g = false;
            double f = 0;
            while (!g)
            {
                g = double.TryParse(Console.ReadLine(), out f);
                if (!g)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.WriteLine("Попробуйте ещё раз!");
                }
            }
            return f;
        }
        public static int ReadNumberInt()
        {
            bool g = false;
            int f = 0;
            while (!g)
            {
                g = int.TryParse(Console.ReadLine(), out f);
                if (!g)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.WriteLine("Попробуйте ещё раз!");
                }
            }
            return f;
        }
        public static int ReadNumberForArr()
        {
            Console.WriteLine("Введите длину массива: ");
            bool g = false;
            int f = 0;
            while (!g)
            {
                g = int.TryParse(Console.ReadLine(), out f);
                if (!g)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.WriteLine("Попробуйте ещё раз!");
                }
                else if (f <= 1)
                {
                    Console.WriteLine("Длина массива не может быть меньше 2");
                    g = false;
                }
            }
            return f;
        }
        public static int ReadNumberForGame()
        {
            bool g = false;
            int f = 0;
            while (!g)
            {
                g = int.TryParse(Console.ReadLine(), out f);
                if (!g)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.WriteLine("Попробуйте ещё раз!");
                }
                else if (f > 3)
                {
                    Console.WriteLine("Выход за диапазон!");
                    g = false;
                }
                else if (f < 1)
                {
                    Console.WriteLine("Выход за диапазон!");
                    g = false;
                }
            }
            return f;
        }
        public static int ReadNumberForGame2()
        {
            bool g = false;
            int f = 0;
            while (!g)
            {
                g = int.TryParse(Console.ReadLine(), out f);
                if (!g)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.WriteLine("Попробуйте ещё раз!");
                }
                else if (f > 10)
                {
                    Console.WriteLine("Выход за диапазон!");
                    g = false;
                }
                else if (f < 1)
                {
                    Console.WriteLine("Выход за диапазон!");
                    g = false;
                }
            }
            return f;
        }
    }
}
