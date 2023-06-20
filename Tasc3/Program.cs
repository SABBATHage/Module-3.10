using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            string num = Console.ReadLine();
            int N = int.Parse(num);

            bool isNotPrimeNum = false;
            int i = 2;
            while (i < N)
            {
                if (N % i == 0) { isNotPrimeNum = true; }
                i++;
            }

            if (isNotPrimeNum)
            {
                Console.WriteLine($"Число {N} не является простым.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Число {N} простое");
                Console.ReadLine();
            }
        }
    }
}
