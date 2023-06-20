using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую в игре 21!");
            Console.WriteLine("Сколько карт у Вас в руке?");
            string num = Console.ReadLine();
            int hand = int.Parse(num);
            int sum = 0;
            
            for (int i = 1; i <= hand; i++)
            {
                Console.WriteLine($"Введите номинал {i} карты");
                string card = Console.ReadLine();

                if (card.Equals("J") || card.Equals("Q") || card.Equals("K") || card.Equals("T"))
                {
                    sum += 10;
                }
                else
                {
                    int cardValue = int.Parse(card);
                    switch (cardValue)
                    {
                        case 6:
                            sum += 6;
                            break;
                        case 7:
                            sum += 7;
                            break;
                        case 8:
                            sum += 8;
                            break;
                        case 9:
                            sum += 9;
                            break;
                        case 10:
                            sum += 10;
                            break;
                    }
                }
            }
            Console.WriteLine($"Сумма ваших очков = {sum}");
            Console.ReadLine();
        }
    }
}
