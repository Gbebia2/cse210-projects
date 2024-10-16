using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private string text;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = SplitTextIntoWords(text);
    }

    private List<Word> SplitTextIntoWords(string text)
    {
        List<Word> wordsList = new List<Word>();
        string[] splitWords = text.Split(' ');

        foreach (string word in splitWords)
        {
            wordsList.Add(new Word(word));
        }

        return wordsList;
    }

    public string GetDisplayText()
    {
        string displayText = $"{reference.GetDisplayText()}\n";
        foreach (var word in words)
        {
            displayText += $"{word.GetDisplayText()} ";
        }
        return displayText.Trim();
    }

    public bool AreAllWordsHidden()
    {
        foreach (var word in words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int index = random.Next(0, words.Count);
        words[index].Hide();
    }
}