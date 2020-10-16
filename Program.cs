using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int sum = Unit2Quiz2.SumBetween(7, 12);
            Console.WriteLine("Sum is: " + sum);
            string myStr = "Hello World";
            myStr = Unit2Quiz2.RemoveVowels(myStr);
            Console.WriteLine("myStr without vowels: " + myStr);
            Unit2Quiz2.Func();

        }
    }
}
