using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Load scriptures from file or predefined list
        List<Scripture> scriptureLibrary = LoadScripturesFromFile("scriptures.txt");

        // Check if the library is empty
        if (scriptureLibrary.Count == 0)
        {
            Console.WriteLine("No scriptures found in the library.");
            return;
        }

        // Choose a random scripture from the list
        Random rand = new Random();
        int randomIndex = rand.Next(scriptureLibrary.Count);

        // Select the scripture at the random index
        Scripture scripture = scriptureLibrary[randomIndex];

        // Start the memorization process
        scripture.StartMemorization();
    }

    // Method to load scriptures from a file
    static List<Scripture> LoadScripturesFromFile(string fileName)
    {
        List<Scripture> scriptures = new List<Scripture>();
        try
        {
            foreach (var line in File.ReadLines(fileName))
            {
                // Split the reference and text based on the first space
                string[] parts = line.Split(new char[] { ' ' }, 2);
                if (parts.Length == 2)
                {
                    // Create a Reference object and a Scripture object
                    string[] referenceParts = parts[0].Split(':');
                    if (referenceParts.Length == 2)
                    {
                        int chapter = int.Parse(referenceParts[0]);
                        int verseStart = int.Parse(referenceParts[1]);
                        scriptures.Add(new Scripture(new Reference(parts[0], chapter, verseStart), parts[1]));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
        }
        return scriptures;
    }
}
