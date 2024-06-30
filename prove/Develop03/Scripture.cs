using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _reference;
    public List<Word> _words = new List<Word>();

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
       if (numberToHide > _words.Count)
       {
        numberToHide = _words.Count;
       }
       Random random = new Random();
       var indices = Enumerable.Range(0, _words.Count);

       foreach (var index in indices)
       {
        _words[index].Hide();
       }
    
    }


    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}

