using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой создайте метод, который выведет все числа от 1 до N. N – число которое пользователь вводит с клавиатуры. (Использовать рекурсию)
/// </summary>
namespace Methods_008
{
    delegate void Operation(int n, int i);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n = int.Parse(Console.ReadLine());
            Rec(n,1);         
            Console.ReadKey();
        }
        //static void Rec(int n, int i)
        static Operation Rec = (n, i) =>
        {
            Console.WriteLine(i);
            if (i == n)
            {
                return;
            }
            ++i;
            Rec(n, i);
        };
    }
}
