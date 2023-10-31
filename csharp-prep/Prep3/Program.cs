using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        string playAgain = "yes";
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 111);

            Console.Write("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());

            int count = 1;
            
            do
            {
                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                count++;
                Console.Write("Guess again: ");
                userGuess = int.Parse(Console.ReadLine());
            } while (userGuess != magicNumber);

            Console.WriteLine($"You guessed it! You made {count} guesses.");
            Console.WriteLine();
            Console.Write("Do you want to play agian? ");
            playAgain = Console.ReadLine();
            playAgain = playAgain.ToLower();
        } while (playAgain == "yes");
    }
}