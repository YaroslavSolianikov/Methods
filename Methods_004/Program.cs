using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу консольный калькулятор. В данной программе должны быть четыре метода, метод для сложения, вычитания, умножения и деления.
/// Каждый из методов должен принимать 2 целочисленных аргумента и выполнять соответствующею действие.
/// Метод для деления должен выполнять проверку деления на ноль. Также необходимо предоставить пользователю возможность вводить знак арифметической операции,
/// в зависимости от знака вызывать соответствующий метод.
/// Также пользователю необходимо предоставить возможность вводит значения аргументов.
/// </summary>
namespace Methods_004
{
    class Program
    {
        delegate double Operation(double a, double b);
        //delegate double Operation();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Operation +,-,*,/");
            char sign = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter number:");
            int b = int.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    //Operation Sum = () => a + b;
                    Console.WriteLine($"result of sum = {Sum(a,b)}");
                    break;
                case '-':
                    //Operation Sub = () => a - b;
                    Console.WriteLine($"result of sub = {Sub(a,b)}");
                    break;
                case '*':
                    //Operation Mult = () => a * b;
                    Console.WriteLine($"result of Mult = {Mult(a,b)}");
                    break;
                case '/':
                    if (b != 0)
                    {
                        //Operation Div = () => a / b;
                        Console.WriteLine($"result of div = {Div(a,b)}");
                    }
                    else
                        Console.WriteLine("b = 0!!!");
                    break;
                default:
                    Console.WriteLine("incorrect sign!");
                    break;
            }
            Console.ReadKey();
        }
        static Operation Sum = (a, b) => a + b;
        static Operation Sub = (a, b) => a - b;
        static Operation Mult = (a, b) => a * b;
        static Operation Div = (a, b) => a / b;
    }
}
