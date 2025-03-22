public class Word
{
    private string _text;
    private bool _hidden;

    // Constructor to initialize the word with its text
    public Word(string text)
    {
        _text = text;
        _hidden = false;
    }

    // Method to hide the word (replace it with underscores)
    public void Hide()
    {
        _hidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _hidden;
    }

    // Method to display the word or its underscores if hidden
    public string Display()
    {
        if (_hidden)
            return new string('_', _text.Length); // Display underscores instead of the word
        return _text; // Display the word as is
    }
}
