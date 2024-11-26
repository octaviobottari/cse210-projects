using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideWords(int count)
    {
        var visibleWords = _words.Where(word => !word.IsHidden).ToList();
        var random = new Random();
        for (int i = 0; i < count && visibleWords.Any(); i++)
        {
            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AreAllWordsHidden()
    {
        return _words.All(word => word.IsHidden);
    }

    public override string ToString()
    {
        return $"{_reference}\n{string.Join(' ', _words)}";
    }
}
