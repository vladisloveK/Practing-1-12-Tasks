﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _7_task
{
    public class Program
    {
        public static void Generate(uint k, List<string> mass)
        {
            if (mass.Count > 0 && mass.Count <= 7)
            {
                int[] a = new int[k];
                for (int i = 0; i < k; i++)
                {
                    a[i] = 1;
                }
                do
                {
                    string s = "";
                    for (int i = 0; i < a.Length; i++)
                    {
                        s += mass[a[i] - 1] + " ";
                    }
                    Console.WriteLine(s);
                } while (NextSet(ref a, mass.Count, k));
            }
        }
        public static bool NextSet(ref int[] a, int n, uint m)
        {
            int j = (int)(m - 1);
            while (j >= 0 && a[j] == n)
            {
                j--;
            }
            if (j < 0)
            {
                return false;
            }
            a[j]++;
            if (j == m - 1)
            {
                return true;
            }
            for (int k = j + 1; k < m; k++)
            {
                a[k] = 1;
            }
            return true;
        }
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            List<string> mass = new List<string>();
            do
            {
                Console.WriteLine("Введите элемент. Для завершения введите пустую строку.");
                string str = Console.ReadLine().Replace(" ", "");
                if (!mass.Contains(str) && str != "")
                {
                    mass.Add(str);
                }else if (mass.Contains(str) && str != "")
                {
                    Console.WriteLine("Уже добавлено");
                }
                else
                {
                    break;
                }
                
            } while (true);
            uint k;
            bool ok;
            if (mass.Count > 0 && mass.Count<=7)
            {
                do
                {
                    Console.WriteLine("Введите длину слов: ");
                    ok = uint.TryParse(Console.ReadLine(), out k);
                } while (!ok);
                Generate(k,mass);
            }
            
        }
    }
}
