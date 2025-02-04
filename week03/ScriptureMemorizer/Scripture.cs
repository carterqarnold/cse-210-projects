using System;
using System.Dynamic;

class Scripture
{
    public Reference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        return string.Join(" ", Words.Select(word => word.IsHidden ? new string('_', word.showText().Length) : word.showText()));
    }

    public void HideRandomWord()
    {
        
        Random random = new Random();
        int index = random.Next(Words.Count);
        Words[index].IsHidden = true;
        
        
    }
}