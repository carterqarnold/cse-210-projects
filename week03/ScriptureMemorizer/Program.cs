using System;

class Program
{
    static void Main(string[] args)
    {
         Scripture scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        Console.Clear();
        Console.WriteLine($"{scripture.reference1}: {scripture.GetDisplayText()}");

        while (true)
        {
            Console.WriteLine("Press Enter to hide words, or type 'quit' to exit:");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
            Console.Clear();
            Console.WriteLine($"{scripture.reference1}: {scripture.GetDisplayText()}");
        }
    }
}