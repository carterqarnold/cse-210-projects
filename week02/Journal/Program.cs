using System;
using System.IO.Pipes;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        while (response != "5")
        {
            Console.WriteLine("Hello World! This is the Journal Project.");
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
    
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
    
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")
            {                
                Entry entrys = new Entry();
                PromptGenerator randPrompt = new PromptGenerator();
                string thePrompt = randPrompt.GetRandomPrompt();
                entrys._entry = Console.ReadLine();
                entrys._date = "11/3/25";
                entrys._prompt = thePrompt;
            }

            else if (response == "2")
            {
                Entry entrys = new Entry();
                DailyActivities journal = new DailyActivities();
                string anEntry = entrys._entry;
                journal.AddEntry(anEntry);
                journal.DisplayAll();
            }

            else if (response == "3")
            {
                DailyActivities journal = new DailyActivities();
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else if (response == "4")
            {
                DailyActivities journal = new DailyActivities();
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
        }
    }
}