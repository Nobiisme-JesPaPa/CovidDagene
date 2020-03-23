using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess;
            bool run = false;
            Random n = new Random();
            int number n.Next(1,10);
            int guessCounter = 0;
            int guessLimit = 3;
            bool OutOfGuesses = false;

            Console.WriteLine("Gæt et nummer imellem 1-10");
            while (!run && !OutOfGuesses)
            {
                try
                {
                    Console.WriteLine("Guess the number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guessCount < guessLimit)
                    {
                        if (guess == number)
                        {
                            Console.WriteLine("Congrats you guessed it!!!");
                            run = true;
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine("Number chosen is too high");
                            guessCount++;
                       }
                    }
                    else
                    {
                        OutOfGuesses = true;
                    }
                }
                catch(FormatException fEx)
                {
                    Console.WriteLine("Wrong input");
                }
            }
        }
    }
}
