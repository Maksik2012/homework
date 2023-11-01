using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любое число");

            int number;
            int.TryParse(Console.ReadLine(), out number);

            int result = number % 2;

            if(result == 0)
            {
                Console.WriteLine("Это число является чётным");
            }
            else
            {
                Console.WriteLine("Это число является не чётным");
            }
        }
    }
}
