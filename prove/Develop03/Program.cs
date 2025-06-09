using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {


        // test references
        Reference referenceOne = new Reference("2 Nephi", 2, 25);


        // test word
        Word wordExample = new Word("pickles");

        wordExample.GetWord();
        Console.WriteLine(wordExample.GetWord());

        // test scripture
        List<Scripture> scriptures = new List<Scripture>();
        // Connect a list to the class it is related to <> 
        Scripture scriptureOne = new Scripture(referenceOne, "Adam fell that men might be; and men are, that they might have joy");
        // Scripture scriptureTwo = new Scripture("");
        // Scripture scriptureThree = new Scripture("");
        // Scripture scriptureFour = new Scripture("");


        while (true)
        {
            scriptureOne.DisplayScripture();

            // if (scriptureOne.AllWordsHidden())
            // {
            //     
            //     Console.ReadLine();
            //     break;
            // }
            Console.WriteLine("Hidden Complete. Press q to exit");
            Console.WriteLine("Press Enter to hide more words");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "q")
            {
                break;
            }



            scriptureOne.HideWords();
        }
        


    }
}