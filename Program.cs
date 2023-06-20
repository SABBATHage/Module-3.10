using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            string num = Console.ReadLine();
            int a = int.Parse(num);
            if (a % 2  == 0)
            {
                Console.WriteLine($"Число {a} четное ");
            }
            else
            {
                Console.WriteLine($"Число {a} нечетное");
            }
            Console.ReadKey();
        }
    }
}
