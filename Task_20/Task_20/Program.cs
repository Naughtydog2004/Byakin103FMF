using System;
using System.Threading;
namespace Task_20
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
            Console.WriteLine("Задача 20. Является ли массив 3x3 магическим квадратом");
            Console.ResetColor();
            int n = 3;
            int[,] arr = new int[n, n];
            string s;
            ConsoleKeyInfo e;
            Console.Write("Для запуска нажмите любую клавишу (Esc - прервать)");
            e = Console.ReadKey(true);
            if (e.Key == ConsoleKey.Escape)
            {
                MyInput.Exit();
            }
            Console.WriteLine();
            Random rnd = new Random();
            bool check = false, isMagic = false, allLines = false, allColumns = false, firstDiag = false, secDiag = false;
            int c = 0, number = 0, sum = 0;
            for (int i = 1; i <= 3 * 3; i++)
            {
                number = number + i;
            }
            number = number / n;
            do
            {
                arr = new int[n, n];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        check = false;
                        while (!check)
                        {
                            check = true;
                            arr[i, j] = rnd.Next(1, n * n + 1);
                            for (int k = 0; k < n; k++)
                            {
                                for (int p = 0; p < n; p++)
                                {
                                    if (!(k == i && p == j) && (arr[i, j] == arr[k, p]))
                                    {
                                        check = false;
                                        break;
                                    }
                                }
                                if (!check) break;
                            }
                        }
                    }
                }
                c++;
                allLines = true;
                allColumns = true;
                firstDiag = true; 
                secDiag = true;
                for (int i = 0; i < n; i++)
                {
                    sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum = sum + arr[i, j];
                    }
                    if (sum != number) allLines = false;
                }
                for (int i = 0; i < n; i++)
                {
                    sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum = sum + arr[j, i];
                    }
                    if (sum != number) allColumns = false;
                }
                sum = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == j)
                        {
                            sum = sum + arr[i, j];
                        }
                    }
                }
                if (sum != number) firstDiag = false;
                sum = 0;
                for (int i = 0; i < n; i++)
                {

                    for (int j = 0; j < n; j++)
                    {
                        if (i == (n - 1 - j))
                        {
                            sum = sum + arr[i, j];
                        }
                    }
                }
                if (sum != number) secDiag = false;
                if (allLines == true && allColumns == true && firstDiag == true && secDiag == true)
                {
                    isMagic = true;
                }
            }
            while (!isMagic);
            Console.WriteLine();
            if (isMagic == true)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0, 4}", arr[i, j]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Данный массив является магическим квадратом");
                Console.WriteLine("Попытка №" + c);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0, 4}", arr[i, j]);
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                }
                Console.WriteLine("Данный массив НЕ является магическим квадратом");
            }
            MyInput.Exit();
        }
    }
}