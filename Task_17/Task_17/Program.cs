using System;
using System.Threading;
namespace Task_17
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
            Console.WriteLine("Задача 17. Минимальное натуральное число из цифр данного числа");
            Console.ResetColor();
            int n = 0;
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
            n = MyInput.Int32("Введите натуральное число: ", "+", true);
            s = Convert.ToString(n);
            int length = s.Length;
            double divider = 0;
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                divider = Math.Pow(10, (double)(length - i - 1));
                arr[i] = (n / (int)divider) % 10;
            }

            int mini = 0, buf = 0;
            for (int i = 0; i < length; i++)
            {
                if ((arr[i] < arr[mini]) && (arr[i] != 0))
                {
                    mini = i;
                }
            }
            buf = arr[0];
            arr[0] = arr[mini];
            arr[mini] = buf;

            Array.Sort(arr, 1, length - 1);
            int outint = arr[0];
            for (int i = 1; i < length; i++)
            {
                outint = outint * 10 + arr[i];
            }
            Console.WriteLine("\nОтвет: " + outint);

            MyInput.Exit();
        }
    }
}