using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Напишите программу, в которой создайте метод, который принимает в качестве параметров три целочисленных значения 
/// и возвращает значение каждого аргумента, умноженного на 10. (Использовать out и ref)
/// </summary>
namespace Methods_006
{
    class Program
    {
        delegate void Mult(ref int num1, ref int num2, ref int num3, out int res1, out int res2, out int res3);
        static void Main(string[] args)
        {
            Console.WriteLine("enter 3 numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
          
            Result(ref num1,ref num2, ref num3, out int res1, out int res2, out int res3);
            Console.WriteLine($"result {res1} {res2} {res3}");
            Console.ReadLine();
        }
        static Mult Result = (ref int num1, ref int num2, ref int num3, out int res1, out int res2, out int res3) =>
        {
            res1 = num1 * 10;
            res2 = num2 * 10;
            res3 = num3 * 10;
        };  
    }
}
