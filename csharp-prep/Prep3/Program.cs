using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attempts = 0;

            Console.WriteLine("Welcome to the 'Guess My Number' game!");
            
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {attempts} attempts.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower() == "yes";
            Console.WriteLine(); 
        }

        Console.WriteLine("Thanks for playing!");
    }
}
