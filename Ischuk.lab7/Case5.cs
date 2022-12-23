using Ischuk.lab5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ischuk.lab6
{
    /// <summary>
    /// Класс для сортировки массива.
    /// </summary>
    internal class Case5
    {
        private int lenArr;
        private int[] arr;
        /// <summary>
        /// Конструктор без параметра. Задаёт длину массива по умолчанию.
        /// </summary>
        public Case5()
        {
            lenArr = 10;

        }
        /// <summary>
        /// Конструктор с параметром для ввода длины массива вручную.
        /// </summary>
        /// <param name="_lenArr"> Параметр длины массива вводимый пользователем. </param>
        public Case5(int _lenArr)
        {
            lenArr = _lenArr;
        }








        /// <summary>
        /// Метод копирования массива.
        /// </summary>
        /// <param name="arr"> Исходный массив. </param>
        /// <param name="arr1"> Пустой массив для копии. </param>
        public static int[] Copy(int[] arr)
        {
            int[] arr1 = arr;
            for (int i = 0; i < arr.Length; i++)
                arr1[i] = arr[i];
            return arr1;
        }
        /// <summary>
        /// Метод вывода массива в консоль.
        /// </summary>
        /// <param name="arr"> Исходный массив. </param>
        public static void OutputArray(int[] arr)
        {
            if (arr.Length <= 100)
            {
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(" {0}", arr[i]);
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Заполнение массива рандомными числами.
        /// </summary>
        /// <param name="newarr"> Пустой массив для заполнения. </param>
        /// <returns> Элемент массива. </returns>
        public static int[] RandomArray(int[] newarr)
        {
            Random rnd = new Random();
            for (int i = 0; i < newarr.Length; i++)
                newarr[i] = rnd.Next(-1000000, 1000000);
            return newarr;
        }


        /// <summary>
        /// Конструктор задающий дефолтную длину массива
        /// </summary>

        public void sort()
        {
            arr = new int[lenArr];
            RandomArray(arr);
            int[] arr1 = Copy(arr);
            Console.WriteLine("Массив: ");
            OutputArray(arr);

            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            ShellSort(arr);
            stopwatch1.Stop();
            Console.WriteLine("Сортировка Шелла: ");
            OutputArray(arr);
            Console.WriteLine("Время сортировки: " + stopwatch1.ElapsedMilliseconds + " Мс");

            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            ShakerSort(arr1);
            stopwatch2.Stop();
            Console.WriteLine("Сортировка Перемешиванием: ");
            OutputArray(arr1);
            Console.WriteLine("Время сортировки: " + stopwatch2.ElapsedMilliseconds + " Мс");
            if (stopwatch2.ElapsedMilliseconds > stopwatch1.ElapsedMilliseconds)
            {
                Console.WriteLine("Сортировка Шелла быстрее сортировки перемешиванием на " + (stopwatch2.ElapsedMilliseconds - stopwatch1.ElapsedMilliseconds) + " Мс");

            }
            else
            {
                Console.WriteLine("Сортировка Перемешиванием быстрее сортировки Шелла на " + (stopwatch1.ElapsedMilliseconds - stopwatch2.ElapsedMilliseconds) + " Мс");
            }
        }

        /// <summary>
        /// Метод сортировки Шелла.
        /// </summary>
        /// <param name="arr"> Исходный массив. </param>
        public void ShellSort(int[] arr)
        {
            int j;
            int step = arr.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (arr.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (arr[j] > arr[j + step]))
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + step];
                        arr[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }
        /// <summary>
        /// Метод перестановки двух элементов массива.
        /// </summary>
        /// <param name="myint"> Исходный массив. </param>
        /// <param name="i"> Индекс первого элемента. </param>
        /// <param name="j"> Индекс второго элемнта. </param>
        public void Swap(int[] myint, int i, int j)
        {
            int glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
        /// <summary>
        /// Метод сортировки перемешиванием.
        /// </summary>
        /// <param name="myint"> Исходный массив. </param>
        public void ShakerSort(int[] myint)
        {
            int left = 0,
                right = myint.Length - 1,
                count = 0;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    count++;
                    if (myint[i] > myint[i + 1])
                        Swap(myint, i, i + 1);
                }
                right--;

                for (int i = right; i > left; i--)
                {
                    count++;
                    if (myint[i - 1] > myint[i])
                        Swap(myint, i - 1, i);
                }
                left++;
            }
        }
    }
}
