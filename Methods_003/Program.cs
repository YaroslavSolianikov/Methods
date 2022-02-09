using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Создайте программу, в которой создайте метод, который принимает в качестве аргумента год рождения пользователя и возвращает его полный возраст.
/// </summary>
namespace Methods_003
{
    class Program
    {
        delegate int Years(int year);
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());
            //Years Age = () => DateTime.Now.Year - year;
            Console.WriteLine($"you are {Age(year)} years old");
            Console.ReadKey();
        }
        static Years Age = year =>  DateTime.Now.Year - year;
    }
}
