using System;
using System.Dynamic;

public class Scripture{
        public Reference reference;
        private List<string> _words = new List<string>();
        public Scripture(Reference Reference, string text){
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }
        public void HideRandomWords(int numberToHide){
            foreach numberToHide.Count()
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words.RemoveAt(index);
        
            Random random = new Random();
            int randomIndex = random.Next(Words.Count);
            Words[randomIndex].IsHidden = true; 
            
        }
        public bool IsCompletelyHidden(){
            return;
        }
class Scripture
{
    public Reference referenceclass;
    private List <Word> _words;

    public Scripture(Reference reference, string text)
    {
        referenceclass = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public string GetDisplayText()
    {
        return string.Join(" ", _words.Select(word => word.IsHidden() ? new string('_', word.Text.Length) : word.Text));
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Count);
        _words[index]Word.IsHidden() = true;
    }
}