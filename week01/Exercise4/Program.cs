using System;
using System.Globalization;
using System.Numerics;
using System.Runtime;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");
        string number = "1";
        float totalSum = 0;


        List<string> numbers = new List<string>();
        List<float> floatNumbers = new List<float>();
        List<int> intNumbers = new List<int>();

        while (number != "0")
        {
            Console.WriteLine("Enter number: ");
            string strNumber = Console.ReadLine();
            number = strNumber;
            
            
            numbers.Add(number);
        }
        foreach (string one in numbers)
        {
            int num = int.Parse(one);
            if (num != 0)
            {
                totalSum = totalSum + num;
                intNumbers.Add(num);
                floatNumbers.Add(num);
            }
        }
        float average = totalSum / floatNumbers.Count();
        int largestNum = intNumbers.Max();

        Console.WriteLine(totalSum);
        Console.WriteLine(average);
        Console.WriteLine(largestNum);


    }
}