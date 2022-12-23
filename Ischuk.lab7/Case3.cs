using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab6
{
    internal class Case3
    {
        public static bool CaseThree()
        {
            bool Exit = false;
            Console.WriteLine("Вы действительно хотите выйти?");
            bool f = false;
            while (!f)
            {
                Console.Write("Введите Д для подтверждения и Н для отмены: ");
                string ex = (Console.ReadLine());
                if (ex == "l" || ex == "д" || ex == "L" || ex == "Д")
                {
                    Exit = true;
                    f = true;
                }
                else
                    Console.WriteLine("Введена неверная команда!");
                if (ex == "y" || ex == "н" || ex == "Y" || ex == "Н")
                {
                    Exit = false;
                    f = true;
                }
            }
            return Exit;
        }
    }
}
