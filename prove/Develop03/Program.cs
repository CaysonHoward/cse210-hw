using System;

class Program
{
    static void Main(string[] args)
    {

        Storage storage = new Storage();
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        storage.initScriptures();
        //create storage instance and run init function
        Random rnd = new Random();
        int rndNum = rnd.Next(0,4);
        List<string> scriptureReference = storage.returnScripture(rndNum);
        reference.addReference(scriptureReference[0], scriptureReference[1], scriptureReference[2], scriptureReference[3]);

        string[] splitWords = scriptureReference[4].Split(' ');

        foreach (string w in splitWords)
        {
            word wordObject = new word(w);
            scripture.scriptureWords.Add(wordObject);
        }
        bool wordsHidden = false;
        while (wordsHidden == false)
        {
            reference.createReference();
            scripture.scriptureDisplay();
            wordsHidden = scripture.allWordsHidden();
            if (wordsHidden == false){
                scripture.hideWords();
            }
            Console.WriteLine("\n Type quit or q to leave and enter to hide more scriptures");
            Console.Write("> ");
            string userChoice = Console.ReadLine() ?? "";
            if ((userChoice == "q") || (userChoice == "quit")){
                wordsHidden = true;
                Console.WriteLine("Goodbye!");
            }
            else{
                Console.Clear();
            }
        }
    }

}