using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу в которой создайте метод, который в качестве аргументов принимает 2 числа и возвращает меньшее из них.
/// </summary>
namespace Methods_002
{
    class Program
    {
        delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 numbers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            //Operation Less = () => (a < b) ? a : b;
            Console.WriteLine($"Less number = {Less(a,b)}");
            Console.ReadLine();
        }
        static Operation Less = (a,b) => (a < b) ? a : b;
    }          
}

