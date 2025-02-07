using System;
using System.Globalization;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {

                // Video 1
        Video video1 = new Video("Cinderella", "Charles Perrault", 4912);

        Comment v1comment1 = new Comment("Kaybrielle", "I love princesses, and Cinderella had a dream come true! I am glad that dreams can come true!");
        video1.AddComment(v1comment1.GetComment());

        Comment v1comment2 = new Comment("Teagan", "The Cinderella Movie is pretty long.");
        video1.AddComment(v1comment2.GetComment());

        Comment v1comment3 = new Comment("Kami", "Your outlook, perspective, and charecter is more important than how others think of you or treat you and allows you to keep dreaming.");
        video1.AddComment(v1comment3.GetComment());

        video1.DisplayVideo();

        Console.WriteLine($"Number of Comments: {video1.NumberComments()}");
        Console.WriteLine("Comments:");
        video1.DisplayComments();

                // Video 2
        Video video2 = new Video("Journaling Suggestions", "Chase A Allen", 400);
        
        Comment v2comment1 = new Comment("Carter", "Great journaling suggestions! Could you do a video on how you could remember to journal in the first place?");
        video2.AddComment(v2comment1.GetComment());

        Comment v2comment2 = new Comment("Bridger", "These suggestions are good, I have been doing these already, and I would also suggest that you write down your feelings.");
        video2.AddComment(v2comment2.GetComment());

        Comment v2comment3 = new Comment("Skyler", "I agree with Bridger. Write your hearts desires, fears, worrys, joys, and the things you are grateful for.");
        video2.AddComment(v2comment3.GetComment());

        video2.DisplayVideo();

        Console.WriteLine($"Number of Comments: {video2.NumberComments()}");
        Console.WriteLine("Comments:");
        video2.DisplayComments();
        
                // Video 3
        Video video3 = new Video("Fire Starting Fun!", "Jace 'The Camping Genius'", 600);
        
        Comment v3comment1 = new Comment("John", "What is the name of that big firestick? It was awesome!");
        video3.AddComment(v3comment1.GetComment());

        Comment v3comment2 = new Comment("Crew", "Have you heard of the Fire Bombs? They are a good firestarter too!");
        video3.AddComment(v3comment2.GetComment());

        Comment v3comment3 = new Comment("Flamethrower", "I still believe in flamethrowers, but you were the closest anyone has gotten to changing my mind!");
        video3.AddComment(v3comment3.GetComment());

        video3.DisplayVideo();

        Console.WriteLine($"Number of Comments: {video3.NumberComments()}");
        Console.WriteLine("Comments:");
        video3.DisplayComments();
    }
}