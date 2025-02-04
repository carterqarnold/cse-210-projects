using System;

class Program
{
    static void Main(string[] args)
    {
        // I have included a command to show just the reference if you would like to try with just the reference for convenience.

        int count = 0;
        Scripture scripture = new Scripture(new Reference("John", 3, 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.Clear();
        Console.WriteLine($"{scripture.Reference}: {scripture.GetDisplayText()}");

        while (true)
        {

            Console.WriteLine("Press Enter to hide words, reference to just show the reference, or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }
            
            else if (input.ToLower() == "reference"){
                Console.Clear();
                Console.WriteLine($"{scripture.Reference}");
            }

            else{
                Console.Clear();
                scripture.HideRandomWord();
    
                Console.WriteLine($"{scripture.Reference}: {scripture.GetDisplayText()}");
            }
            
            count = count + 1;
        }  
    }
}

