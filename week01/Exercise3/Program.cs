using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(1,100);
        int guess;
        int guessNumber = 0;

        do
        {
            Console.Write("What is your guess? ");
            guessNumber ++;

            string strGuess = Console.ReadLine();
            guess = int.Parse(strGuess);
            
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
    
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }

        } while (guess != number);
        Console.WriteLine("You guessed it!");

        if (guessNumber != 1)
        {
            string guessednumber = guessNumber.ToString();
            Console.WriteLine($"You guessed {guessNumber} times");
        }

        else{
            Console.WriteLine("You guessed it in 1 guess lucky you!");
        }
    }
}