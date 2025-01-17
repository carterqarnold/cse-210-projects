using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNum = SquareNumber(number);
        
        DisplayResult(name, squaredNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string fav = Console.ReadLine();
        int favNum = int.Parse(fav);
        return favNum;
    }
    static int SquareNumber(int number)
    {
        int squaredNum = number * number;
        return squaredNum;
    }
    static void DisplayResult(string name, int squaredNum)
    {
        Console.WriteLine($"{name}, the square of your number is: {squaredNum}");
    }
    
}