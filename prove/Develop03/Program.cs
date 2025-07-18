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

        Reference referenceTwo = new Reference("Hosea", 4, 3, 5);
        Scripture scriptureTwo = new Scripture(referenceTwo, " 3 Therefore shall the land mourn, and every one that dwelleth therein shall languish, with the beasts of the field, and with the fowls of heaven; yea, the fishes of the sea also shall be taken away. \n 4 Yet let no man strive, nor reprove another: for thy people are as they that strive with the priest. \n 5 Therefore shalt thou fall in the day, and the prophet also shall fall with thee in the night, and I will destroy thy mother.");



        // Scripture scriptureThree = new Scripture("");
        // Scripture scriptureFour = new Scripture("");


        while (true)
        {


            scriptureOne.DisplayScripture();

            scriptureTwo.DisplayScripture();
            Console.WriteLine("Hidden Complete. Press q to exit");
            Console.WriteLine("Press Enter to hide more words");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "q")
            {
                break;
            }



            scriptureOne.HideWords();
            scriptureTwo.HideWords();


            
        }
        


    }
}