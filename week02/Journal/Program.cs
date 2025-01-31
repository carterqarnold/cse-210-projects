// I have added an additional action that allows you to add your own prompts. 
// This action asks for the prompt question takes that question storing it in a variable and then adds it to the prompt questions list

using System;
using System.IO.Pipes;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Entry entrys = new Entry();                
        PromptGenerator randPrompt = new PromptGenerator();
        DailyActivities journal = new DailyActivities();

        string response = "";
        while (response != "6")
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
    
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
    
            Console.WriteLine("5. Add a prompt");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do? ");
            response = Console.ReadLine();

            if (response == "1")
            {                
                string promptQuestion = randPrompt.GetRandomPrompt();
                entrys._date = "11/3/25";
                entrys._prompt = promptQuestion;

                Console.WriteLine(entrys._date);
                Console.WriteLine(randPrompt.GetRandomPrompt());
                string _entry = Console.ReadLine();

                entrys._entry = $"{entrys._date} \n {entrys._prompt} \n{_entry}";
                string anEntry = entrys._entry;
                journal.AddEntry(anEntry);
            }

            else if (response == "2")
            {
                
                journal.DisplayAll();
            }

            else if (response == "3")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else if (response == "4")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }

            else if (response == "5")
            {
                Console.WriteLine("What prompt question would you like to add to the list? ");
                string addedPrompt = Console.ReadLine();
                randPrompt._prompts.Add(addedPrompt);
            }
        }
    }
}