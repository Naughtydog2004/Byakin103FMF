using System;
using System.Threading;
namespace Task_15
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
            Console.WriteLine("Задача 15. Умножение повторяющихся элементов на их индексы");
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
            do
            {
                n = MyInput.Int32("Введите количество элементов массива (от 1 до 20): ", "+", check);
                check = false;
            }
            while (n > 20);
            int[] arr = new int[n];
            Console.WriteLine("\nНажмите клавишу \"1\" для ручного заполнения массива");
            Console.WriteLine("или клавишу \"2\" для автоматического заполнения случайными числами\n");
            check = false;
            do
            {
                e = Console.ReadKey(true);
                if (e.Key == ConsoleKey.D1 || e.Key == ConsoleKey.NumPad1)
                {
                    check = true;
                    for (int i = 0; i < n; i++)
                    {
                        s = "Введите " + i + "-й элемент: ";
                        arr[i] = MyInput.Int32(s, "0+", true);
                    }
                }
                else if (e.Key == ConsoleKey.D2 || e.Key == ConsoleKey.NumPad2)
                {
                    check = true;
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rnd.Next(1, n + 1);
                    }
                }
            }
            while (!check);

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0, 5}", i);
            }
            Console.WriteLine(" индексы");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0, 5}", arr[i]);
            }
            Console.WriteLine(" исходные числа");

            if ((n > 1) && !(arr[0] == 1 && arr[1] == 1))
            {
                check = false;
                int number = n;
                while (!check)
                {
                    check = true;
                    for (int i = 0; i < number; i++)
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (arr[i] == arr[j])
                            {
                                check = false;
                                arr[i] = arr[i] * i;
                                j = i - 1;

                                for (int k = 0; k < n; k++)
                                {
                                    Console.Write("{0, 5}", arr[k]);
                                }
                                Console.WriteLine(" изменения");
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Невозможно произвести преобразования");
            }
            MyInput.Exit();
        }
    }
}