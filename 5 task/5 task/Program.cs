﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace _5_task
{
    public class Program
    {
        public static void result(int n)
        {
            Random rnd = new Random();
            int[,] mass = new int[n, n];
            int max;
            int[] massOut = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rnd.Next(-100, 100);
                    Console.Write(String.Format("{0,3}", mass[i, j]));
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                max = 0;
                for (int j = 0; j < n; j++)
                    if (mass[i, j] > mass[i, max])
                        max = j;
                Console.WriteLine($"Столбец {i} - Matrix[{i},{max}] = {mass[i, max]}");
                massOut[i] = mass[i, max];
            }
            int s = 0;
            for (int i = 0; i < n; i++)
                s += massOut[i] * massOut[n - i - 1];
            Console.WriteLine($"S = {s}");
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(2, 10);
            result(n);

        }
        
    }
}
