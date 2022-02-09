using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу для конвертирования валюты.
/// Пользователь должен иметь возможность ввести курс валюты, в которую он хочет конвертировать, сумму которую он хочет конвертировать
/// . Программа должна вывести сумму денег в соответствующей валюте.
/// </summary>
namespace Methods_005
{
    delegate void Operation(decimal a, decimal b);
    //delegate void Operation();
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the exchange rate");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sum");
            decimal b = decimal.Parse(Console.ReadLine());
            //Operation Sum = () => Console.WriteLine($"Your money = {b / a}");
            Sum(a, b);
            Console.ReadKey();
        }
        static Operation Sum = (a, b) => Console.WriteLine($"Your money = {b/a}");
    }
}
