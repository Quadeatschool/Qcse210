public class Reference
{
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    private string _book;



    // Reference methods
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _startVerse = verse;
        _chapter = chapter;
        _endVerse = -1;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _endVerse = endVerse;
        _startVerse = startVerse;
    }
    
    public string DisplayReference()
    {

        if (_endVerse == -1)
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
        return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
    }
}