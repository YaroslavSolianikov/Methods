using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, которая будет вычислять сумму цифр числа N.
/// Число N пользователь должен вводить с клавиатуры. При решении этой задачи нельзя использовать строки, списки, массивы (ну и циклы, разумеется).
/// </summary>
namespace Methods_009
{
    delegate int Sum(int n);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of digits = {Rec(n)}");
            Console.ReadKey();
        }
        static Sum Rec = n => n < 10 ? n : ((n % 10) + Rec(n / 10));  
        //static int Rec(int n) => n < 10 ? n : ((n % 10) + Rec(n / 10));
    }
}
