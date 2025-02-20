using System;
public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    public void Run(ProgressTracker tracker){
        _name = "Reflecting Activity";

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string stringseconds = Console.ReadLine();
        int seconds = int.Parse(stringseconds);

        tracker.LogActivity("Reflecting Activity", seconds);
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion(){
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
}