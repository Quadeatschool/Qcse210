public class Scripture
{
    private string _textString;
    private Reference _reference;
    private List<Word> _wordList;

    // Scripture Methods

    public Scripture(Reference reference, string textString)
    {
        _textString = textString;
        _reference = reference;
        _wordList = new List<Word>();

        foreach (string word in textString.Split(' '))
        {
            _wordList.Add(new Word(word));
        }

    }
    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine(_reference.DisplayReference());

        foreach (Word word in _wordList)
        {
            Console.Write(word.GetWord() + " ");
        }
        Console.WriteLine();
    }

    public void ClearScreen()
    {
        //This while loop will read true if the spacebar is hit.
        while (Console.ReadKey(true).Key != ConsoleKey.Spacebar)
            // This will clear the console
            Console.Clear();
    }

    public void HideWords(int tally = 1)
    // permanant paramater
    {
        Random rando = new Random();
        var unhiddenWords = _wordList.Where(w => !w.IsHidden()).ToList();
        int toHide = Math.Min(tally, unhiddenWords.Count);

        for (int item = 0; item < toHide; item++)
        {
            int index = rando.Next(unhiddenWords.Count);
            unhiddenWords[index].HideWord();
            unhiddenWords.RemoveAt(index);

        }
    }
    public bool AllWordsHidden()
    {
        return _wordList.All(w => w.IsHidden());
    }
}

