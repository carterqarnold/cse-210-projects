using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string strGradePercentage = Console.ReadLine();

        int gradePercentage = int.Parse(strGradePercentage);
        string letter = "No letter grade available";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }

        else if (gradePercentage >= 80 && gradePercentage <= 90)
        {
            letter = "B";
        }

        else if (gradePercentage >= 70 && gradePercentage <= 80)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60 && gradePercentage <= 70)
        {
            letter = "D";
        }

        else if (gradePercentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"The grade you got was {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations you passed!");
        }

        else
        {
            Console.WriteLine("You can do better next time!");
        }
    }
}