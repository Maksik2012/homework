using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar = 93.22;
            Console.WriteLine("Введите сумму в долларах");

            string num = Console.ReadLine();
            double quantity = Convert.ToDouble(num);

            double result = dollar * quantity;

            Console.WriteLine("Суммма в рублях: " + result);

        }
    }
}
