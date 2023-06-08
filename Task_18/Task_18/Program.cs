using System;
using System.Threading;
namespace Task_18
{
    class MyInput
    {
        public static void Exit()
        {
            while (true)
            {
                ConsoleKeyInfo e;
                Console.WriteLine();
                Console.WriteLine("Программа завершена");
                Console.Write("Начать заново? (Enter - да / Esc - выход): ");
                e = Console.ReadKey();

                if (e.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\n");
                    //Console.Clear();
                    Program.Main();
                }
                else if (e.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
                else
                {
                    //Console.Clear();
                    continue;
                }
            }
        }
        public static int Int32(string text, string type, bool check)
        {
            int vari = 0;
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToInt32(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
                if (check)
                {
                    switch (type)
                    {
                        case "-0+":
                            break;
                        case "-+":
                            if (vari == 0)
                            {
                                check = false;
                            }
                            break;
                        case "0+":
                            if (vari < 0)
                            {
                                check = false;
                            }
                            break;
                        case "+":
                            if (vari <= 0)
                            {
                                check = false;
                            }
                            break;
                        case "-0":
                            if (vari > 0)
                            {
                                check = false;
                            }
                            break;
                        case "-":
                            if (vari >= 0)
                            {
                                check = false;
                            }
                            break;
                    }
                }
            }
            while (!check);
            return vari;
        }

        public static uint UInt32(string text, string type, bool check)
        {
            uint vari = 0;
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToUInt32(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
                if (check)
                {
                    switch (type)
                    {
                        case "0+":
                            if (vari < 0)
                            {
                                check = false;
                            }
                            break;
                        case "+":
                            if (vari <= 0)
                            {
                                check = false;
                            }
                            break;
                    }
                }
            }
            while (!check);
            return vari;
        }
        public static long Int64(string text, string type, bool check)
        {
            long vari = 0;
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToInt64(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
                if (check)
                {
                    switch (type)
                    {
                        case "-0+":
                            break;
                        case "-+":
                            if (vari == 0)
                            {
                                check = false;
                            }
                            break;
                        case "0+":
                            if (vari < 0)
                            {
                                check = false;
                            }
                            break;
                        case "+":
                            if (vari <= 0)
                            {
                                check = false;
                            }
                            break;
                        case "-0":
                            if (vari > 0)
                            {
                                check = false;
                            }
                            break;
                        case "-":
                            if (vari >= 0)
                            {
                                check = false;
                            }
                            break;
                    }
                }
            }
            while (!check);
            return vari;
        }

        public static ulong UInt64(string text, string type, bool check)
        {
            ulong vari = 0;
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToUInt64(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
                if (check)
                {
                    switch (type)
                    {
                        case "0+":
                            if (vari < 0)
                            {
                                check = false;
                            }
                            break;
                        case "+":
                            if (vari <= 0)
                            {
                                check = false;
                            }
                            break;
                    }
                }
            }
            while (!check);
            return vari;
        }
        public static double Double(string text, string type, bool check)
        {
            double vari = 0;
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToDouble(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
                if (check)
                {
                    switch (type)
                    {
                        case "-0+":
                            break;
                        case "-+":
                            if (vari == 0)
                            {
                                check = false;
                            }
                            break;
                        case "0+":
                            if (vari < 0)
                            {
                                check = false;
                            }
                            break;
                        case "+":
                            if (vari <= 0)
                            {
                                check = false;
                            }
                            break;
                        case "-0":
                            if (vari > 0)
                            {
                                check = false;
                            }
                            break;
                        case "-":
                            if (vari >= 0)
                            {
                                check = false;
                            }
                            break;
                    }
                }
            }
            while (!check);
            return vari;
        }
        public static char Char(string text, string type, bool check)
        {
            char vari = ' ';
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToChar(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
            }
            while (!check);
            return vari;
        }
        public static string String(string text, string type, bool check)
        {
            string vari = "";
            ConsoleKeyInfo e;
            //Console.WriteLine();
            do
            {
                if (!check)
                {
                    Console.WriteLine();
                    Console.WriteLine("Некорректные данные. Нажмите Enter");
                }
                try
                {
                    if (check == false)
                    {
                        while (true)
                        {
                            e = Console.ReadKey(true);
                            if (e.Key == ConsoleKey.Escape)
                            {
                                MyInput.Exit();
                            }
                            else if (e.Key == ConsoleKey.Enter)
                            {
                                break;
                            }
                        }
                    }
                    Console.Write(text);
                    vari = Convert.ToString(Console.ReadLine());
                    check = true;
                }
                catch
                {
                    check = false;
                }
            }
            while (!check);
            return vari;
        }
    }
    class Program
    {

        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Задача 18. Вывести \"окантовку\" двумерного массива");
            Console.ResetColor();
            int n = 0, m = 0;
            string s;
            ConsoleKeyInfo e;
            Console.Write("Для запуска нажмите любую клавишу (Esc - прервать)");
            e = Console.ReadKey(true);
            if (e.Key == ConsoleKey.Escape)
            {
                MyInput.Exit();
            }
            Console.WriteLine();
            bool check = true;
            n = MyInput.Int32("Введите количетво строк массива: ", "+", true);
            m = MyInput.Int32("Введите количетво столбцов массива: ", "+", true);
            int[,] arr = new int[n, m];
            Console.WriteLine("Исходный массив:");
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(1, n * m + 1);
                    Console.Write("{0, 5}", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\"Окантовка\":");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || j == 0 || i == n - 1 || j == m - 1)
                    {
                        Console.Write("{0, 5}", arr[i, j]);
                    }
                    else
                    {
                        Console.Write("{0, 5}", " ");
                    }
                }
                Console.WriteLine();
            }


            MyInput.Exit();
        }
    }
}