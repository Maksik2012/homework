using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            string str;
            char Char;
            while (true){
                Console.WriteLine("Введите операцию (Для выхода введите exit)");
                str = Console.ReadLine();

                if(str == "exit")
                {
                    break;
                }
                char.TryParse(str, out Char);


                Console.WriteLine("Введите первое число (Для выхода введите exit)");
                str = Console.ReadLine();

                if (str == "exit")
                {
                    break;
                }
                double.TryParse(str, out a);


                Console.WriteLine("Введите второе число (Для выхода введите exit)");
                str = Console.ReadLine();

                if (str == "exit")
                {
                    break;
                }
                double.TryParse(str, out b);


                switch (Char)
                {
                    case '/':
                        if(b == 0)
                        {
                            result = 0;
                            Console.WriteLine("результат: " + result);
                        }
                        else
                        {
                            result = a / b;
                            Console.WriteLine("результат: " + result);
                        }
                        
                        break;
                    case '*':
                        result = a * b;
                        Console.WriteLine("результат: " + result);
                        break;
                    case '%':
                        result = a % b;
                        Console.WriteLine("результат: " + result);
                        break;
                    case '+':
                        result = a + b;
                        Console.WriteLine("результат: " + result);
                        break;
                    case '-':
                        result = a - b;
                        Console.WriteLine("результат: " + result);
                        break;
                    default:
                        Console.WriteLine("Неизвестный символ");
                        break;
                }
            }
        }
    }
}
