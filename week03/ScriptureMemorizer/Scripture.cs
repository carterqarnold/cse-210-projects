using System;
using System.Dynamic;

public class Scripture{
    public Reference reference1;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text){
    reference1 = reference;
    _words = text.Split(' ').Select(word => new Word(word)).ToList();        }
    public void HideRandomWords(int numberToHide){
        int count = 0;
        while (count != numberToHide){
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index]._isHidden  = true;
            count = count + 1;
        }
        
    }
    public string GetDisplayText(){
        return $"{reference1} \n {_words}";
    }
    public bool IsCompletelyHidden(){
        return true;
    }
}