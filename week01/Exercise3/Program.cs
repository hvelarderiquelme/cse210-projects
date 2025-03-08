using System;
/*Final version*/
class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);
        string guess;
        int numGuess;

        do
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            numGuess = int.Parse(guess);

            if (numGuess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (numGuess < number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (numGuess != number);
    }
}