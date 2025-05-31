public class Word
{
    private string _wordText;
    private bool _hiddenWord;

    public Word(string text)
    {
        _wordText = text;
        _hiddenWord = false;
    }
    public void HideWord()
    {
         _hiddenWord = true;
    }

    public void RevealWord()
    {
        _hiddenWord = false;
    }

    public string GetWord()
    {
        //short hand way to make an if else 
        return _hiddenWord ? new string('_', _wordText.Length) : _wordText;
    }

    public bool IsHidden()
    {
        return _hiddenWord;
    }

}