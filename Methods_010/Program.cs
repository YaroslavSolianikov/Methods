using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой создайте метод, который в качестве аргумента принимает целое число и определяет количество разрядов данного числа.
/// Пользователь должен иметь возможность вводит число с клавиатуры.
/// </summary>
namespace Methods_010
{
    class Program
    {
        delegate void Radix(int a);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            Rank(a);
            Console.ReadKey();
        }
        //static void Rank(int a)
        static Radix Rank = a =>
        {
            int count = 1;
            int res = 0;
            while (a > 10)
            {
                res += a % 10;
                a /= 10;
                count++;
            }
            Console.WriteLine($"{count} digits in number");
        };
    }
}
