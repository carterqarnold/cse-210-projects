using System;
using System.ComponentModel.DataAnnotations;
public class Video{
    public Comment comment;
    private string _title = "";
    private string _author = "";
    private double _length;
    private List<string> comments = new List<string>();
    public Video(string title, string author, double videoTimeInSeconds){
        _title = title;
        _author = author;
        _length = videoTimeInSeconds;
    }
    public void DisplayVideo(){
        Console.WriteLine($"Title: {_title}\nAuthor: {_author} \nLength: {_length} seconds");
    }
    public int NumberComments(){
        return comments.Count();
    }
    public void AddComment(string comment){
        comments.Add(comment);
    }
    public void DisplayComments(){
        foreach (string comment in comments){
            Console.WriteLine($"    {comment}");
        }
    }
   
}
