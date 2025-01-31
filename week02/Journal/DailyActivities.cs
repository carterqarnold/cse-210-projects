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
        foreach (string _entry in _entrys){
            Console.WriteLine(_entry);
        }
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
            foreach (string part in parts){
                Console.WriteLine(part);
            }
        }
    }
}