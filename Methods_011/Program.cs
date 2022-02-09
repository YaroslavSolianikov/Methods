using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_011
{
    delegate void Bank(decimal creditSum, decimal customerSum);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sum of credit");
            decimal creditSum = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sum of customer");
            decimal customerSum = decimal.Parse(Console.ReadLine());
            Info(creditSum, customerSum);
            Console.ReadKey();
        }
        static Bank Info = (creditSum, customerSum) =>
        {
            if (creditSum >= 0 && customerSum >= 0)
            {
                if (creditSum == customerSum)
                {
                    Console.WriteLine("Credit paid");
                }
                else if (creditSum > customerSum)
                {
                    decimal res = creditSum - customerSum;
                    Console.WriteLine($"The customer must pay - {res}");
                }
                else
                {
                    decimal res = customerSum - creditSum;
                    Console.WriteLine($"The customer overpaid - {res}");
                }
            }
            else
            {
                Console.WriteLine("Incorret input");
            }
        };
    }
}
