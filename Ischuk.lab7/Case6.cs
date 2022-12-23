using Ischuk.lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab6
{
    internal class Case6
    {
        private const char Closed = '#';
        private const char ZeroZero = '0';
        private const char OneZero = '1';
        private const char TwoZero = '2';
        private const char ThreeZero = '3';
        private static char[,] Arr2D;
        private const int m = 4;
        private const int n = 11;

        public void Game(char[,] arr)

        {
            bool flag = false;
            int count = 0;
            int Count1 = 0;
            char zero = 'O';
            char x = 'X';
            string ZeroText = "Нолики победили!";
            string xText = "Крестики победили!";
            while (!flag)
            {
                Console.WriteLine("Ход Крестиком");
                GameFunction(arr, x);
                Count1++;
                count = Winner(arr, x, xText, count);
                if (count >= 9)
                {
                    flag = true;
                    break;
                }
                else if (Count1 == 9)
                {
                    flag = true;
                    Console.WriteLine("Игра завершена Ничьёй!");
                    break;
                }

                Console.WriteLine("Ход Ноликом");
                GameFunction(arr, zero);
                Count1++;
                count = Winner(arr, zero, ZeroText, count);
                if (count >= 9)
                {
                    flag = true;
                    break;
                }
                else if (Count1 == 9)
                {
                    flag = true;
                    Console.WriteLine("Игра завершена Ничьёй!");
                    break;
                }

            }

        }
        public void GameFunction(char[,] arr, char x)
        {
            bool flag = false;
            while (!flag)
            {
                Console.WriteLine("Введите столбец");
                int m = ReadNumbers.ReadNumberForGame();
                Console.WriteLine("Введите строку");
                int n = ReadNumbers.ReadNumberForGame();
                if (arr[n, m] == '#')
                {
                    arr[n, m] = x;
                    Console.Clear();
                    Output2DArray(arr);
                    flag = true;
                }
                else
                    Console.WriteLine("Клетка занята!");
            }

        }
        public void GameFunction2(int[,] arr, int[,] arr1)
        {
            bool flag = false;
            while (!flag)
            {
                Console.Write("Введите столбец ");
                int m = ReadNumbers.ReadNumberForGame2();
                Console.Write("Введите строку ");
                int n = ReadNumbers.ReadNumberForGame2();
                arr[n, m] = arr1[n, m];
                Console.Clear();
                Console.WriteLine("   ");
                OutputArr(arr);
                MineCount(arr1);
                if (arr[n, m] == 9)
                {
                    flag = true;
                    Console.WriteLine("Вы проиграли!");
                    OutputArr(arr1);
                }
            }
        }
        public int Winner(char[,] arr, char x, string Text, int count)
        {
            if (arr[1, 1] == x)
                if (arr[1, 2] == x)
                    if (arr[1, 3] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[2, 1] == x)
                if (arr[2, 2] == x)
                    if (arr[2, 3] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[3, 1] == x)
                if (arr[3, 2] == x)
                    if (arr[3, 3] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[1, 1] == x)
                if (arr[2, 1] == x)
                    if (arr[3, 1] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[1, 2] == x)
                if (arr[2, 2] == x)
                    if (arr[3, 2] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[1, 3] == x)
                if (arr[2, 3] == x)
                    if (arr[3, 3] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[1, 1] == x)
                if (arr[2, 2] == x)
                    if (arr[3, 3] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            if (arr[1, 3] == x)
                if (arr[2, 2] == x)
                    if (arr[3, 1] == x)
                    {
                        Console.WriteLine(Text);
                        count = 9;
                    }
            return count;
        }
        public void MineCount(int[,] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.GetLength(0); i++)
                for (int j = 1; j < arr.GetLength(1); j++)
                    if (arr[i, j] == 9)
                    {
                        count++;
                    }
            Console.WriteLine("Количество мин: " + count);

        }


        public void MapArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = Closed;
            arr[0, 0] = ZeroZero;
            arr[1, 0] = OneZero;
            arr[2, 0] = TwoZero;
            arr[3, 0] = ThreeZero;
            arr[0, 1] = OneZero;
            arr[0, 2] = TwoZero;
            arr[0, 3] = ThreeZero;

        }
        public void Output2DArray(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("    " + arr[i, j] + "{0}", j < arr.GetLength(1) - 1 ? "     " : "          ");
                Console.WriteLine();
            }
        }
        public void OutputArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                    Console.Write("  " + arr[i, j] + "{0}", j < arr.GetLength(1) - 1 ? "  " : "  ");
                Console.WriteLine();
            }
        }

        public void CaseSix()
        {
            bool flag = false;
            while (!flag)
            {
                Menu.MenuItem1();
                int number = ReadNumbers.ReadNumberInt();
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Игра Крестики Нолики.");
                        Console.WriteLine("Игроки по очереди ставят фигуры (крестики или нолики) в игровом поле путем ввода ноиера строки и столбца на поле.");
                        Console.WriteLine("Побеждает тот игрок который первым соберет последовательность из 3-х одинаковых фигур (крестиков или ноликов).");
                        Console.ReadKey();
                        Console.Clear();
                        Arr2D = new char[m, m];
                        MapArray(Arr2D);
                        Output2DArray(Arr2D);
                        Game(Arr2D);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Игра Сапёр.");
                        Console.WriteLine("Вам представлено игровое поле размером 10х10 клеток.");
                        Console.WriteLine("Игрок открывает клетки вводом номера строки и столбца.В клетке содержится значение от 0 до 8 показывающее количество мин вокруг этой клетки.");
                        Console.WriteLine("Клетка со значением 9 является миной.");
                        Console.WriteLine("Нажмите Enter чтобы продолжить");
                        Console.ReadKey();
                        Console.Clear();
                        int[,] arr = new int[n, n];
                        RandomArr(arr);
                        Console.WriteLine("   ");
                        int[,] Arr0 = new int[n, n];
                        ArrZero(Arr0);
                        OutputArr(Arr0);
                        int[,] Arr1 = new int[n, n];
                        ArrZeroOpen(Arr1, arr);
                        MineCount(Arr1);
                        GameFunction2(Arr0, Arr1);
                        Console.ReadKey();
                        break;
                    case 3:
                        flag = true;
                        break;
                }
            }
        }
        public int[,] RandomArr(int[,] arr)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i, 0] = i;
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[0, j] = j;
            for (int i = 1; i < arr.GetLength(0); i++)
                for (int j = 1; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(7, 10);

            return arr;
        }
        public int[,] ArrZero(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i, 0] = i;
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[0, j] = j;
            return arr;
        }
        public int[,] ArrZeroOpen(int[,] arr, int[,] arr1)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = 0;
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                    if (arr1[i, j] == 9)
                    {
                        arr[i, j] = arr1[i, j];
                        if (arr[i + 1, j] != 9)
                            arr[i + 1, j]++;
                        if (arr[i - 1, j] != 9)
                            arr[i - 1, j]++;
                        if (arr[i, j + 1] != 9)
                            arr[i, j + 1]++;
                        if (arr[i, j - 1] != 9)
                            arr[i, j - 1]++;
                        if (arr[i - 1, j - 1] != 9)
                            arr[i - 1, j - 1]++;
                        if (arr[i + 1, j + 1] != 9)
                            arr[i + 1, j + 1]++;
                        if (arr[i + 1, j - 1] != 9)
                            arr[i + 1, j - 1]++;
                        if (arr[i - 1, j + 1] != 9)
                            arr[i - 1, j + 1]++;
                    }
            for (int i = 0; i < arr.GetLength(0); i++)
                arr[i, 0] = i;
            for (int j = 0; j < arr.GetLength(1); j++)
                arr[0, j] = j;
            return arr;
        }
    }
}
