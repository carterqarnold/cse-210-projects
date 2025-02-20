using System;
public class ListingActivity : Activity{
    private List<string> _prompts = new List<string>();
    public void Run(ProgressTracker tracker){
        _name = "Listing Activity";

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string stringseconds = Console.ReadLine();
        int seconds = int.Parse(stringseconds);        

        tracker.LogActivity("Listing Activity", seconds);
        tracker.DisplayProgress();
    
    }
     public string GetRandomPrompt(){
        Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
    }
}