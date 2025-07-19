using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

        // test word
        Word wordExample = new Word("pickles");
        wordExample.GetWord();
        Console.WriteLine(wordExample.GetWord());

        // test scripture
        List<Scripture> scriptures = new List<Scripture>();
        // Connect a list to the class it is related to <> 
        Reference referenceOne = new Reference("2 Nephi", 2, 25);
        Scripture scriptureOne = new Scripture(referenceOne, "Adam fell that men might be; and men are, that they might have joy");

        Reference referenceTwo = new Reference("Hosea", 4, 3, 5);
        Scripture scriptureTwo = new Scripture(referenceTwo, " 3 Therefore shall the land mourn, and every one that dwelleth therein shall languish, with the beasts of the field, and with the fowls of heaven; yea, the fishes of the sea also shall be taken away. \n 4 Yet let no man strive, nor reprove another: for thy people are as they that strive with the priest. \n 5 Therefore shalt thou fall in the day, and the prophet also shall fall with thee in the night, and I will destroy thy mother.");


        while (true)
        {
            scriptureOne.DisplayScripture();
            scriptureTwo.DisplayScripture();

            // Check if all words are hidden in both scriptures
            if (scriptureOne.AllWordsHidden() && scriptureTwo.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are now hidden. Exiting program.");
                break; // or Environment.Exit(0);
            }

            Console.WriteLine("Hidden Complete. Press quit to exit");
            Console.WriteLine("Enter a number of words to hide (or just press Enter for 1): ");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
            {
                break;
            }


        //Creativity---------
            int wordsToHide = 1; // Default to hiding 1 word
            if (!string.IsNullOrWhiteSpace(input))
            {
                int.TryParse(input, out wordsToHide);
                if (wordsToHide < 1) wordsToHide = 1;
            }

            scriptureOne.HideWords(wordsToHide);
            scriptureTwo.HideWords(wordsToHide);


            
        }
        


    }
}