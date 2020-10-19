using System;
using System.Collections.Generic;

namespace MyFirstProject
{
    public class Unit2Quiz2
    {
        public static int SumBetween(int start, int end)
        {
            int min = Math.Min(start,end);
            int max = Math.Max(start,end);
            int sum = 0;
            for (int i = min; i <= max; i++)
            {
                sum += i;

            }
            return sum;
        }

        public static string RemoveVowels(string str)
        {
            string result = "";
            string vowels = "aeiouAEIOU";
            for (int i = 0; i < str.Length; i++)
            {
                if (vowels.IndexOf(str[i]) == -1)
                {
                    result += str[i];

                }
            }
            return result;
        }

        public static void Func()
        {
            int a = 1;
            FuncA(a);
            int b = 2;
            b = FuncB(b);
            var c = new List<int>() { 8, -9, 12 };
            c.Add(15);
            Funcc(c);
            var d = new List<int>() { -5, 6, 4 };
            FuncD(d);
            var e = new List<int>() { 7, 12, -33 };
            FuncE(e);

            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
            Console.WriteLine("c:" + String.Join(",", c));
            Console.WriteLine("d:" + String.Join(",", d));
            Console.WriteLine("e:" + String.Join(",", e));
            
        }

        static void FuncA(int x)
        {
            x++;
        }
        static int FuncB(int x)
        {
            x++;
            return x;
        }
        static void Funcc(List<int> x)
        {
            x.Add(49);
        }
        static void FuncD(List<int> x)
        {
            var temp = new List<int>();
            temp = x;
            temp.Add(5);
        }
        static void FuncE(List<int> x)
        {
            var temp = new List<int>();
            for (int i = 0; i < x.Count; i++)
            {
                temp.Add(x[i]);

            }
            temp.Add(4);
        }

    }
}