using Ischuk.lab5;
using Ischuk.lab6;
using static System.Net.Mime.MediaTypeNames;

namespace Ischuk.lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            while (!isExit)
            {
                Menu.MenuItem();
                int number = ReadNumbers.ReadNumberInt();
                switch (number)
                {
                    default:
                        Console.WriteLine("Такого пункта меню не существует");
                        Console.ReadKey();
                        break;

                    case 1:
                        Case1.CaseOne();
                        Console.ReadKey();
                        break;
                    case 2:
                        Case2.CaseTwo();
                        Console.ReadKey();
                        break;
                    case 3:
                        isExit = Case3.CaseThree();
                        break;
                    case 4:
                        Case4.CaseFour();
                        break;
                    case 5:
                        Console.WriteLine("1 - Длина массива по умолчанию.");
                        Console.WriteLine("2 - Ввод длины в ручную.");
                        int numbers = ReadNumbers.ReadNumberInt();
                        switch (numbers)
                        {
                            case 1:
                                Case5 c5 = new Case5();
                                c5.sort();
                                break;
                            case 2:
                                int _lenArr = ReadNumbers.ReadNumberForArr();
                                Case5 _c5 = new Case5(_lenArr);
                                _c5.sort();
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case 6:
                        Case6 c6 = new Case6();
                        c6.CaseSix();
                        break;
                    case 7:
                        Case7 c7 = new Case7();
                        bool flag = false;
                        while (!flag)
                        {
                            Menu.MenuItem2();
                            int number2 = ReadNumbers.ReadNumberInt();
                            switch (number2)
                            {
                                case 1:
                                    bool flag1 = false;
                                    while (!flag1)
                                    {
                                       
                                        Menu.MenuItem3();
                                        int number1 = ReadNumbers.ReadNumberInt();
                                        switch (number1)
                                        {
                                            case 1:
                                                c7.VowCon();
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                string strman = c7.ManString();
                                                Case7 c8 = new Case7(strman, strman, strman);
                                                c8.VowCon();
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                flag1 = true;
                                                break;
                                        }
                                    }
                                    break;
                                case 2:
                                    bool flag2 = false;
                                    while (!flag2)
                                    {
                                        Menu.MenuItem3();
                                        int number1 = ReadNumbers.ReadNumberInt();
                                        switch (number1)
                                        {
                                            case 1:
                                                c7.Acount();
                                                Console.ReadKey();
                                                ; break;
                                            case 2:
                                                string strman = c7.ManString();
                                                Case7 c8 = new Case7(strman, strman, strman);
                                                c8.Acount();
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                flag2 = true;
                                                break;
                                        }
                                    }
                                    break;
                                case 3:
                                    bool flag3 = false;
                                    while (!flag3)
                                    {
                                        Menu.MenuItem3();
                                        int number1 = ReadNumbers.ReadNumberInt();
                                        switch (number1)
                                        {
                                            case 1:
                                                c7.EqualString();
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                string strman = c7.ManString();
                                                string strman1 = c7.ManString();
                                                Case7 c8 = new Case7(strman, strman, strman1);
                                                c8.EqualString();
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                flag3 = true;
                                                break;
                                        }
                                    }
                                    break;
                                case 4:
                                    flag = true;
                                    break;

                            }
                        }
                        break;
                }
            }
        }
    }
}