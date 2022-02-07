using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int max = 100;
            int min = 0;
            bool againPlay = true;
            int guessNumber = 0;

            while (againPlay)
            {
                int guessCount = 0;
                int secretNumber=random.Next(min,max+1);
                while(guessNumber != secretNumber)
                {
                    Console.Write("Guess the number between 1 to 100 and your number is :");
                    guessNumber = Convert.ToInt32(Console.ReadLine());
                    guessCount++;
                    if (guessNumber < secretNumber)
                    {
                        Console.WriteLine("Number is low");
                    }
                    else if(guessNumber > secretNumber)
                    {
                        Console.WriteLine("Number is high");
                    }
                }

                Console.WriteLine("Congrats. You get the secret number.\n You guess the number at {0} try.",guessCount);
                Console.WriteLine("Do you want to play again?(y/n)");
                string confirm = Console.ReadLine();
                if(confirm.ToUpper() == "Y")
                {
                    againPlay = true;
                    guessNumber = 0;
                }
                else
                {
                    againPlay = false;
                    Console.WriteLine("Thanks for playing.");
                }
            }
            Console.ReadLine();
        }
    }
}
