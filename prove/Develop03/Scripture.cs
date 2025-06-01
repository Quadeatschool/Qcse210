// public class Scripture
// {
//     private string _textString;
//     private Reference _reference;

//     private List<Word> _wordList;

//     // Scripture Methods

//     public Scripture(List<Word> wordList, Reference reference, string textString)
//     {
//         _textString = textString;
//         _reference = reference;
//         _wordList = wordList;

//         wordList = new List<Word>();

//         foreach (string word in textString.Split(' '))
//         {
//             wordList.Add(new Word(word));
//         }

//     }
//     public void DisplayScripture()
//     {
//         Console.WriteLine(_reference.DisplayReference());

//         foreach (Word word in _wordList)
//         {
//             Console.Write(word.GetWord() + " ");
//         }
//         Console.WriteLine();
//     }

//     public void ClearScreen()
//     {
//         // This will start by displaying "AAA" and waiting for the user to press the enter key
//         Console.WriteLine("AAA");
//         Console.ReadLine();

//         // This will clear the console
//         Console.Clear();

//         // This will show "BBB" in the console where "AAA" used to be
//         Console.WriteLine("BBB");
//     }

//     public string HideWords()
//     {
//         Random hid = new Random();
//         int hidcount = 0;


//     }
// }