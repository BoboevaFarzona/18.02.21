using System;
using System.Threading.Tasks;
using System.Threading;

namespace New_folder
{
    class Program
    {
        static int Dlina = 21;
        static void Main(string[] args)
        {
            int[] nums = new int[] { 24, 22, 32, 48, 13, 67, 3, 41, 31, 18, 54, 61, 22, 1, 3, 6, 27, 0, 57, 19, 24, 63, 32, 38, 45, 52 };
            Task[] tasks = new Task[26];
            for (int i = 0; i < 26; i++)
            {
                try
                {
                    tasks[i] = Task.Run(() => Stream(nums[i]));
                }
                catch (Exception)
                { }
                Thread.Sleep(900);
            }
            tasks[0].Wait();
            Console.ReadKey();
        }
        static void Stream(int left)
        {
            try
            {
                int Limite = new Random().Next(3, 7);
                int Top = 0;
                int black = Top;
                int topLim = (Dlina - 5) / Limite;
                while (true)
                {
                    if (Top >= Limite * topLim)
                    {
                        Top = 0;
                    }
                    black = Top;
                    for (int i = 0; i < black; i++)
                    {
                        Console.CursorTop = i;
                        Console.CursorLeft = left;
                        System.Console.WriteLine(" ");
                    }
                    for (int i = 0; i < Limite; i++)
                    {
                        if (i == (Limite - 1))
                            Console.ForegroundColor = ConsoleColor.White;
                        else if (i == (Limite - 2))
                            Console.ForegroundColor = ConsoleColor.Green;
                        else
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.CursorTop = Top++;
                        Console.CursorLeft = left;
                        switch (new Random().Next(0, 35))
                        {
                            case 0: Console.WriteLine("A"); break;
                            case 1: Console.WriteLine("B"); break;
                            case 2: Console.WriteLine("C"); break;
                            case 3: Console.WriteLine("D"); break;
                            case 4: Console.WriteLine("E"); break;
                            case 5: Console.WriteLine("F"); break;
                            case 6: Console.WriteLine("G"); break;
                            case 7: Console.WriteLine("H"); break;
                            case 8: Console.WriteLine("I"); break;
                            case 9: Console.WriteLine("J"); break;
                            case 10:Console.WriteLine("K"); break;
                            case 11:Console.WriteLine("L"); break;
                            case 12:Console.WriteLine("M"); break;
                            case 13:Console.WriteLine("N"); break;
                            case 14:Console.WriteLine("O"); break;
                            case 15:Console.WriteLine("P"); break;
                            case 16:Console.WriteLine("Q"); break;
                            case 17:Console.WriteLine("R"); break;
                            case 18:Console.WriteLine("S"); break;
                            case 19:Console.WriteLine("T"); break;
                            case 20:Console.WriteLine("U"); break;
                            case 21:Console.WriteLine("V"); break;
                            case 22:Console.WriteLine("W"); break;
                            case 23:Console.WriteLine("X"); break;
                            case 24:Console.WriteLine("Y"); break;
                            case 25:Console.WriteLine("Z"); break;
                            case 26:Console.WriteLine("0"); break;
                            case 27:Console.WriteLine("1"); break;
                            case 28:Console.WriteLine("2"); break;
                            case 29:Console.WriteLine("3"); break;
                            case 30:Console.WriteLine("4"); break;
                            case 31:Console.WriteLine("5"); break;
                            case 32:Console.WriteLine("6"); break;
                            case 33:Console.WriteLine("7"); break;
                            case 34:Console.WriteLine("8"); break;
                            case 35:Console.WriteLine("9"); break;
                        }
                    }
                    if (Top == Limite)
                    {
                        for (int i = Top; i < Dlina; i++)
                        {
                            Console.CursorTop = i;
                            Console.CursorLeft = left;
                            System.Console.WriteLine(" ");
                        }
                    }

                    Thread.Sleep(8000);
                    Top = black + new Random().Next(1, Limite);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}