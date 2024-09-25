using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("What is your magic number? ");
       //string magicNumber = Console.ReadLine();
       //int mN = int.Parse(magicNumber);

       Random randomGenerator = new Random();
        int mN = randomGenerator.Next(1, 101);

        int theGuess = 0;

       while (theGuess != mN)
       {
        Console.Write("What is your guess?" );
        string guess = Console.ReadLine();
        theGuess = int.Parse(guess);

        if (theGuess < mN)
        {
            Console.WriteLine("Higher");
        }
        else if (theGuess > mN)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
       }
    }
}