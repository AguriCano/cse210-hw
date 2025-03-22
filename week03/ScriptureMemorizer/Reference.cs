public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // Constructor to initialize the reference (book, chapter, and verses)
    public Reference(string book, int chapter, int verseStart, int verseEnd = -1)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    // Method to display the reference in the format "Book Chapter:Verse" or "Book Chapter:Verse-Range"
    public string Display()
    {
        if (_verseEnd == -1)
            return $"{_book} {_chapter}:{_verseStart}";
        return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
}
