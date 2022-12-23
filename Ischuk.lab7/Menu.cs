using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab5
{
    internal class Menu
    {
        public static void MenuItem()
        {
            Console.Clear();
            Console.WriteLine("Выберите пункт меню");
            Console.WriteLine("1 - Отгадать ответ уравнения");
            Console.WriteLine("2 - Об авторе");
            Console.WriteLine("3 - Выход");
            Console.WriteLine("4 - Проверка Try-Cath-Finally");
            Console.WriteLine("5 - Сортировка");
            Console.WriteLine("6 - Игра");
            Console.WriteLine("7 - Работа со строками");
        }
        public static void MenuItem1()
        {
            Console.Clear();
            Console.WriteLine("1 - Крестики нолики");
            Console.WriteLine("2 - Сапёр");
            Console.WriteLine("3 - Вернуться в меню");
        }
        public static void MenuItem2()
        {
            Console.Clear();
            Console.WriteLine("1 - Посчитать количество гласных и согласных букв в строке.");
            Console.WriteLine("2 - Посчитать количество букв А(а) в строке.");
            Console.WriteLine("3 - Даны две строки. У них одина-ковые начала. Вывести на экран, сколько первых симво-лов этих строк совпадают.");
            Console.WriteLine("4 - Вернуться назад");
        }
        public static void MenuItem3()
        {
            Console.Clear();
            Console.WriteLine("1 - Тестовая строка");
            Console.WriteLine("2 - Введение строки в ручную");
            Console.WriteLine("3 - Вернуться назад");
        }
    }
}
