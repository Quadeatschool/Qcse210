using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // List<Scripture> scriptures = new List<Scripture>();
        // // Connect a list to the class it is related to <> 
        // Scripture scriptureReferenceOne = new Scripture("");
        // Scripture scriptureReferenceTwo = new Scripture("");
        // Scripture scriptureReferenceThree = new Scripture("");
        // Scripture scriptureReferenceFour = new Scripture("");


        // test references
        Reference referenceExample = new Reference("mormon", 5, 23);

        referenceExample.DisplayReference();

        // test word
        Word wordExample = new Word("pickles");

        wordExample.GetWord();
        Console.WriteLine(wordExample.GetWord());


    }
}