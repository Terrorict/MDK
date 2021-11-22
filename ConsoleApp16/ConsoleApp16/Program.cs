using System;
using System.Text.Json.Serialization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, c, m, d, k, l;
            int[,] A = new int[10, 10];
            Console.Write("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите m: ");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Wod(A, n, m);
            Wiw(A, n, m);
            Fun(A, n, m, c, d);
            Console.WriteLine("Произведение: ");
            Wiw(A, n, m);
            Console.ReadKey();

        }
        static void Wod(int[,] A, int n, int m)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    A[i, j] = rnd.Next(0, 10);
                Console.WriteLine();
            }
        }
        static void Fun(int[,] A, int n, int m, int c, int d)
        {
            int k, l;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (c == A[i, j])
                    {
                        k = i;
                        for (l = 0; l < m; l++)
                            A[k, l] = A[k, l] * d;
                        break;
                    }
            }
        static void Wiw(int[,] A, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write(A[i, j] + "  ");
                Console.WriteLine();
            }
        }
    }
}

