using System;
public class PromptGenerator
{
    public List<string> promptsList = new List<string>{
        "What was the best part of my day?", "Who made me smile today?",
        "What are some things I can do better? What will I do to implement those things tomorrow?",
        "What did I learn today that can help my future generations?", "How was today special for you?"
    }; Random randomPrompt = new Random(promptsList);
    
    public void GetRandomPrompt()
    {
        Console.WriteLine(randomPrompt);
    }
}