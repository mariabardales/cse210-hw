using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guessint;
        int cont=0;
        do
        {
            Console.WriteLine("What is your guess? ");
            string nguess=Console.ReadLine();
            guessint=int.Parse(nguess);
            if (guessint>number)
            {
                Console.WriteLine("Lower");
            }
            else if (guessint<number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
            cont=cont+1;
        } while (guessint!=number);
        Console.WriteLine($"Number of attempts: {cont}");
    }
}