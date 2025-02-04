using System;
using System.Dynamic;
class Word
{
    private string Text { get; set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }
    public string showText(){
        return Text;
    }
}
