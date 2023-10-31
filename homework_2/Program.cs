using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите первое число");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе первое число");
            b = double.Parse(Console.ReadLine());

            double result = (a + b) / 2;

            Console.WriteLine(result);
        }
    }
}
