public class Scripture
{
    private string _textString;

    // Scripture Methods

    private string DisplayScripture()
    {

    }

    private void ClearScreen()
    {
        // This will start by displaying "AAA" and waiting for the user to press the enter key
Console.WriteLine("AAA");
Console.ReadLine();

// This will clear the console
Console.Clear();

// This will show "BBB" in the console where "AAA" used to be
Console.WriteLine("BBB");
    }
}