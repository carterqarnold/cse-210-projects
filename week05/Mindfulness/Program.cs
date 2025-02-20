using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Activity mainActivity = new Activity();
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();

        ListingActivity listingActivity = new ListingActivity();
        ProgressTracker progressTracker = new ProgressTracker();

        mainActivity.DisplayStartingMessage();
        string response = Console.ReadLine();
        while (response != "4")
        {
            if (response == "1")
            {
                Console.WriteLine("Welcome to the Breathing Activity");
                Console.WriteLine();
                Console.WriteLine("This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you regognize the power you have and how you can use it in other aspects of your life.");
                
                breathingActivity.Run(progressTracker);
                breathingActivity.ShowSpinner(2000);
                breathingActivity.DisplayEndingMessage();

            }
    
            else if (response == "2")
            {
                Console.WriteLine("Welcome to the Reflecting Activity");
                Console.WriteLine();
                Console.WriteLine("This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you regognize the power you have and how you can use it in other aspects of your life.");
                
                reflectingActivity.ShowSpinner(2000);
                reflectingActivity.Run(progressTracker);
                reflectingActivity.DisplayEndingMessage();
            }
    
            else if (response == "3")
            {
                Console.WriteLine("Welcome to the Reflecting Activity");
                Console.WriteLine();
                Console.WriteLine("This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you regognize the power you have and how you can use it in other aspects of your life.");
                
                listingActivity.ShowSpinner(2000);
                listingActivity.Run(progressTracker);
                listingActivity.DisplayEndingMessage();
            }
    
            else
            {
                Console.WriteLine("Your response was not a number 1-5 please try again.");
            }
            mainActivity.DisplayEndingMessage();
        }
    }
}