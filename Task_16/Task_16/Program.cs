using System;
using System.Threading;
namespace Task_16
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
            Console.WriteLine("Задача 16. Проверка массива из 1000 элементов на самую длинную цепочку");
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
            bool check2 = true;
            do
            {
                n = MyInput.Int32("Введите количество элементов массива (от 1 до 1000): ", "+", check);
                check = false;
            }
            while (n > 1000);
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
                        check2 = true;
                        s = "Введите значение " + i + "-го элемента (от 1 до 6): ";
                        do
                        {
                            arr[i] = MyInput.Int32(s, "+", check2);
                            check2 = false;
                        }
                        while (arr[i] > 6);
                    }
                }
                else if (e.Key == ConsoleKey.D2 || e.Key == ConsoleKey.NumPad2)
                {
                    check = true;
                    Random rnd = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        arr[i] = rnd.Next(1, 7);
                    }
                }
            }
            while (!check);

            if (n <= 20)
            {
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0, 4}", i);
                }
                Console.WriteLine(" индексы");
                for (int i = 0; i < n; i++)
                {
                    Console.Write("{0, 4}", arr[i]);
                }
                Console.WriteLine(" исходный массив");
            }

            int start = 0, length = 0, maxlength = 1;
            for (int i = 0; i < n; i++)
            {
                length = 0;
                for (int j = i; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        length++;
                    }
                    else 
                    {
                        if (length > maxlength)
                        {
                            maxlength = length;
                            start = i;
                        }
                        break;
                    }
                }
            }

            Console.Write("Значения элементов: ");
            for (int i = start; i < maxlength; i++) 
            {
                Console.Write("{0, 4}", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Длина цепочки = " + maxlength);
            Console.WriteLine("Начальный индекс цепочки = " + start);
            MyInput.Exit();
        }
    }
}