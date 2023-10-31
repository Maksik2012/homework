using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double sumResult, multResult;

            Console.WriteLine("Введите первое число");
            double.TryParse(Console.ReadLine(), out a);

            Console.WriteLine("Введите второе число");
            double.TryParse(Console.ReadLine(), out b);

            Console.WriteLine("Введите третье число");
            double.TryParse(Console.ReadLine(), out c);

            sumResult = a + b + c;
            Console.WriteLine("Сумма: " + sumResult);

            multResult = a * b * c;
            Console.WriteLine("Произведение: " + multResult);
        }
    }
}
