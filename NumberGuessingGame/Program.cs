using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number in between 0 and 100: ");
                string a = Console.ReadLine();

                if (a.All(Char.IsDigit))
                {
                    int i = int.Parse(a);

                    if (i > winNum)
                    {
                        Console.WriteLine("To High! Guess lower...");
                    }
                    else if (i < winNum)
                    {
                        Console.WriteLine("Too Low! Guess higher...");
                    }
                    else if (i == winNum)
                    {
                        Console.WriteLine("YOU WIN!");
                        win = true;
                    }
                } else
                {
                    Console.WriteLine("Please guess a number in between 0 and 100.");
                }
                Console.WriteLine();
            } while (win == false);

            Console.WriteLine("Thank you for playing the game!");
            Console.WriteLine("Press any key to finish.");
            Console.ReadKey(true);
        }
    }
}
