using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу в которой создайте метод, который принимает в качестве параметров три целочисленных аргумента
/// и выводит на экран среднее арифметическое значений аргументов.
/// </summary>
namespace Methods_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Average of 3 numbers = {Average(a,b,c)}");
            Average(a,b,c);
            Console.ReadKey();
        }
        static void Average(int a, int b, int c) => Console.WriteLine($"Average of 3 numbers = {(a+b+c)/3}");
        //static int Average(int a, int b, int c) => (a + b + c) / 3; //Console.WriteLine($"Average of 3 numbers = {(a + b + c) / 3}");
    }
}
