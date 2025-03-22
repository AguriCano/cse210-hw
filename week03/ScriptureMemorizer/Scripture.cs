using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private string _text;
    private List<Word> _words;
    private int _memorizedCount;

    // Constructor to initialize scripture with reference and text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        _words = new List<Word>();
        _memorizedCount = 0;

        foreach (string word in _text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Method to display the scripture with the reference and words
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{_reference.Display()}");

        // Show words and how many words are memorized
        foreach (var word in _words)
        {
            Console.Write(word.Display() + " ");
        }

        Console.WriteLine($"\n\nWords memorized: {_memorizedCount} / {_words.Count}");
    }

    // Method to hide a random word that has not been hidden yet
    public void HideRandomWords()
    {
        // Filter out words that are not hidden
        List<Word> visibleWords = _words.FindAll(word => !word.IsHidden());

        if (visibleWords.Count > 0)
        {
            // Select a random visible word
            Random rand = new Random();
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            _memorizedCount++;  // Increase memorized word count
        }
    }

    // Method to start the memorization process
    public void StartMemorization()
    {
        bool allHidden = false;
        while (!allHidden)
        {
            // Display the scripture
            DisplayScripture();

            // Ask the user to press Enter to hide more words or type 'quit' to exit
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                allHidden = true;
            }
            else
            {
                // Hide a random visible word
                HideRandomWords();

                // Check if all words are hidden
                allHidden = _words.TrueForAll(word => word.IsHidden());
            }
        }

        // Display the final scripture with all words hidden
        DisplayScripture();
        Console.WriteLine("All words are now hidden. Press any key to exit.");
        Console.ReadKey();
    }
}
