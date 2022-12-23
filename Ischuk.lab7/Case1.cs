using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab5
{
    /// <summary>
    /// Класс для работы с Функцией.
    /// </summary>
    static class Case1
    {
        /// <summary>
        /// Метод сравнения введённого ответа с значением функции.
        /// </summary>
        /// <param name="result"> Значение функции. </param>
        public static void MathGame(double result)
        {
            bool x = false;
            int count = 1;
            Console.WriteLine("У вас есть три попытки чтобы отгадать ответ");
            while (!x & count != 4)
            {
                Console.WriteLine("{0} попытка", count++);
                Console.Write("Введите свой ответ: ");
                double otv = ReadNumbers.ReadNumber();
                if (otv == Math.Round(result))
                {
                    Console.WriteLine("Ответ верный");
                    x = true;
                }
                else if (count == 4)
                {
                    Console.WriteLine("Ответ неверный!");
                    Console.WriteLine("Вы израсходовали все попытки!");
                    count = count++;
                }
                else
                {
                    count = count++;
                    Console.WriteLine("Ответ неверный");
                }
            }
        }
        /// <summary>
        /// Ввод переменных функции.
        /// </summary>
        public static void CaseOne()
        {
            Console.WriteLine("Чему равно значение функции: F = sin^2(log5(b)/sqrt(cos(2a))");
            Console.WriteLine("Введите число А: ");
            double a = ReadNumbers.ReadNumber();
            Console.WriteLine("Введите число B: ");
            double b = ReadNumbers.ReadNumber();
            double result = Equation(a, b);
            MathGame(result);
        }
        /// <summary>
        /// Подсчёт значения функции.
        /// </summary>
        /// <param name="a"> Переменная Функции А. </param>
        /// <param name="b"> Переменная Функции В. </param>
        /// <returns> Результат Функции. </returns>
        public static double Equation(double a, double b)
        {
           
            double s1 = Math.Log(b, 5);
            double s2 = Math.Sqrt(Math.Cos(2 * a));
            double result = Math.Pow(Math.Sin(s1 / s2), 2);
            return result;

        }
    }  
}

