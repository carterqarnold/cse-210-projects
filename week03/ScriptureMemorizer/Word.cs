using System;
using System.Dynamic;

public class Word{
    private string _text;
    private bool _isHidden;
    public Word(string text){
        _text = text;
    }
    public void Hide(){

    }
    public void Show(){

    }
    public bool IsHidden(){
        return _isHidden;
    }
        public string GetDisplayText(){
            return _text;
        }
}