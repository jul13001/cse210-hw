using System;

public class Scripture
{
    private string _reference;
    private List<Word> _words = new List<Word>();

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
       var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
       var wordsToHide = visibleWords.OrderBy(x => random.Next()).Take(numberToHide);
       foreach (var word in wordsToHide)
       {
        word.Hide();
       }
    
    }
    public string GetDisplayText()
    {
        return $"{_reference} - {string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }


    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}

