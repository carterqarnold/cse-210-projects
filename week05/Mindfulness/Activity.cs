using System;
using System.Security.Principal;

public class Activity{
        protected string _name = "";
        private int _duration;
        public void SetDuration(int duration){
            _duration = duration;
        }
        public void DisplayStartingMessage(){
            Console.WriteLine($"Menu Options:\n  1. Start breathing activity\n  2. Start reflecting activity\n  3. Start listing activity\n  4.Quit\nSelect a choice from the menu: ");
        }
        public void DisplayEndingMessage(){
            Console.WriteLine("Well done!!");
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        }
        public void ShowSpinner(int seconds){  
            Console.Write("|");
            
            Thread.Sleep(seconds);
            
            Console.Write("\b \b");
            Console.Write("/");

            Thread.Sleep(seconds);

            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(seconds);

            Console.Write("\b \b");
            Console.Write("""\"""); 

            Thread.Sleep(seconds);

            Console.Write("\b \b"); 
            Console.Write("|"); 

            Thread.Sleep(seconds);
            Console.Write("\b \b");
        }
    }