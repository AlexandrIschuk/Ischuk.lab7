using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab5
{
    internal class Case4
    {
        public static void CaseFour()
        {
            try
            {
                Console.WriteLine("Введите любое число");
                int g = ReadNumbers.ReadNumberInt();
                int isResult = 5 / g;
                Console.Write("Результат: " + isResult);
                Console.ReadKey();
            }
            catch (DivideByZeroException)
            {
                Console.Write("Нельзя делить на 0");
                Console.ReadKey();
            }
        }
    }
}
