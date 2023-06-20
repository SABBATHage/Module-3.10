using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tusc5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное число диапазона");
            
            int max = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int num = rnd.Next(0,max);

            Console.WriteLine("Введите загаданное программой число");
            while (1 == 1) 
            {
                string line = Console.ReadLine();
                if (String.IsNullOrEmpty(line))
                {
                    Console.WriteLine($"Загадано было число {num}");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    int chek = int.Parse(line);
                    if (chek < num)
                    {
                        Console.WriteLine("Загаданное число больше");
                    }

                    if (chek > num)
                    {
                        Console.WriteLine("Загаданное число меньше");
                    }

                    if (chek == num)
                    {
                        Console.WriteLine("Поздравляем, вы угадали");
                        Console.ReadLine();
                        break;
                    }
                }
            }
        }
    }
}
