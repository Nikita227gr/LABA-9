using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Var15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] F = new int[7, 10];
            Random r = new Random();
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 10; j++)
                    F[i, j] = r.Next(-10, 11);

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(F[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 1");
            int max = F[0,0];
            foreach (int i in F)
            {
                if (i > max)
                    max = i;
            }
            Console.WriteLine($"максимальный элемент равен = {max}");
            Console.WriteLine("");
            Console.WriteLine("Задание 2");
            int S = 0;
            for (int i = 0; i < 7; i++)
                if (F[i, 0] > -3)
                    S += F[i, 0];
            Console.WriteLine($"Сумма элементов больших -3 = {S}");
            Console.WriteLine("");
            Console.WriteLine("Задание 3");
            int[] G = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int k = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (F[i, j] == 0)
                        k++;
                }
                G[i] = k;
            }
                    for (int i = 0; i < G.Length; i++)
            {
                Console.Write(G[i] + "\n");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Задание 4");
            int mas = 0;
            foreach (var item in F)
            {
                if (item > 0)
                {
                    mas++;
                }
            }
            int[] K = new int[mas];
            int f = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (F[i, j] > 0)
                    {
                        K[f] = F[i, j];
                        f++;
                    }
                }
            }
            for (int i = 0; i < K.Length; i++)
            {
                Console.Write($"{K[i]}, ");
            }
        }
    }
}
