using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusc4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину последовательности");

            int l = int.Parse(Console.ReadLine());

            int min = int.MaxValue;

            for (int i = 1; i <= l; i++) 
            {
                Console.WriteLine($"Введите {i} число");
                int m = int.Parse(Console.ReadLine());
                if (m < min) { min = m; }
            }

            Console.WriteLine($"Наименьшее число последовательности {min}");
            Console.ReadLine();
        }
    }
}
