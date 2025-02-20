using System;
public class BreathingActivity : Activity{
    public void Run(ProgressTracker tracker){
        _name = "Breathing Activity";
        
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.WriteLine("How long, in seconds, would you like for your session?");
        string stringseconds = Console.ReadLine();
        int seconds = int.Parse(stringseconds);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        DateTime currentTime = DateTime.Now;
        
        int _firstTime = 0;

    
        while (currentTime != futureTime || currentTime !> futureTime){

            if (_firstTime == 0){
                Console.Clear();
                Console.Write("3 Breath in...");
                    
                Thread.Sleep(1000);
                Console.Clear();

                Console.Write("2 Breath in...");

                    
                Thread.Sleep(1000);
                Console.Clear();

                Console.Write("1 Breath in...");
                    
                Thread.Sleep(1000);
                Console.Clear();

                Console.Write("3 Breath out...");

                Thread.Sleep(1000);
                Console.Clear();

                Console.Write("2 Breath out...");
                    
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("1 Breath out...");
            }
            if (_firstTime == 0){
                Console.Clear();
                Console.Write("4 Breath in...");
                    
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("3 Breath in...");
                
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("2 Breath in...");
        
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("1 Breath in...");
    
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("4 Breath out...");
    
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("3 Breath out...");
    
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("2 Breath out...");
    
                Thread.Sleep(1000);
                Console.Clear();
                Console.Write("1 Breath out...");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.Write("6 Breath in...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("5 Breath in...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("4 Breath in...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("3 Breath in...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("2 Breath in...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("1 Breath in...");

            Console.Clear();
            Thread.Sleep(1000);

            Console.Write("6 Breath out...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("5 Breath out...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("4 Breath out...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("3 Breath out...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("2 Breath out...");

            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("1 Breath out...");

            Thread.Sleep(1000);
            _firstTime = _firstTime + 1;
            currentTime = DateTime.Now;
        }

        tracker.LogActivity("Breathing Activity", seconds);
        tracker.DisplayProgress();
    }
        
}
