public class Comment
{
    private string _name;
    private string _text;

    // Constructor to initialize the comment details
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // Properties to access the private fields
    public string Name => _name;
    public string Text => _text;
}
