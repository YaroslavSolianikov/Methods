using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Написать программу, в которой создайте один метод, который будет вычислять площадь и периметр прямоугольника.
/// Сторони прямоугольника пользователь должен иметь возможность вводит с клавиатуры.
/// </summary>
namespace Methods_007
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Width");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter height");
            int height = int.Parse(Console.ReadLine());

            GetRecData(ref width, ref height, out int Per, out int Area);
            Console.WriteLine($"Perimetr = {Per}");
            Console.WriteLine($"Area = {Area}");
            Console.ReadKey();
        }
        static void GetRecData(ref int width, ref int height, out int Per, out int Area)
        {
            Area = height * width;
            Per = (height + width) * 2;         
        }
    }
}
