public class Reference
{
    private int _chapter;
    private int _verse;
    private string _book;

    // Reference methods
    public Reference(string book,  int chapter, int verse)
    {
        _book = book;
        _verse = verse;
        _chapter = chapter;
    }
    public void DisplayReference()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}");
    }
}