using System;
using System.Dynamic;

public class Scripture{
        public Reference reference1;
        private List<Word> _words = new List<Word>();
        public Scripture(Reference reference, string text){
        reference1 = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();        }
        public void HideRandomWords(int numberToHide){
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index]Word.IsHidden() = true;
            
        }
        public bool IsCompletelyHidden(){
            return;
        }