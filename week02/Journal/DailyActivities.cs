using System;
public class DailyActivities
{
    public List<string> _entrys = new List<string>();

    public void AddEntry(string anEntry)
    {
        _entrys.Add(anEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine(_entrys);
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        outputFile.WriteLine(_entrys);
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(parts);
        }
    }
}