using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int UserChoice = 0;
        Menu menu = new Menu();
        Prompt prompt = new Prompt();
        saveFile save = new saveFile();
        WriteEntry userEntry = new WriteEntry();
        loadFile fileload = new loadFile();

        List<string> entry = new List<string> { };

        while (UserChoice != 5)
        {
            menu.Display();
            Console.Write("> ");

            string MenuChoice = Console.ReadLine() ?? "5";
            UserChoice = int.Parse(MenuChoice);

            if (UserChoice == 1)
            {
                string dailyPrompt = prompt.WritingPrompt();
                Console.WriteLine(dailyPrompt);
                entry.Add(userEntry.EntryCreation(dailyPrompt));
            }
            else if (UserChoice == 2)
            {
                foreach (string word in entry)
                {
                    Console.WriteLine($"{word}");
                };
            }
            else if (UserChoice == 3)
            {
                Console.WriteLine("Warning! This will delete your current entries and load new ones.");
                Console.WriteLine("Would you like to continue? (y/n)");
                Console.Write("> ");
                string userFileLoad = Console.ReadLine() ?? "UnamedFile";
                if (userFileLoad == "y")
                {
                    Console.WriteLine("Please enter the file name");
                    Console.Write("> ");
                    string fileName = Console.ReadLine() ?? "UnamedFile";
                    entry = fileload.load(fileName);
                }
            }
            else if (UserChoice == 4)
            {
                save.Save(entry);
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}

class Menu
{
    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program");
        Console.WriteLine("Please select on of the following");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
    }

}

class WriteEntry
{
    DateTime theCurrentTime = DateTime.Now;
    public string EntryCreation(string prompt)
    {
        Console.Write("> ");
        string entry = theCurrentTime.ToShortDateString();
        entry += "\n";
        entry += prompt;
        entry += "\n";
        entry += Console.ReadLine() ?? "";
        return entry;
    }
}

class Prompt
{
    List<string> prompts = new List<string>{
        "What was the best thing that happened to you today?",
        "What is something that made you laugh today?",
        "What steps did you take today towards a goal youre working on?",
        "Who made your day better today? How can you pay that feeling forward?",
        "What made today unique?",
        "What is one thing you want to remember from today?",
        "When did you feel most authentically yourself today?",
        "How can you make tomorrow (even) better than today?",
        "If you were given $10,000 and only an hour to spend it, how would you do it?",
        "If you could live 24 hours in the body of any animal, which animal would it be?",
        "How would you describe your spirituality?",
        "What in your life brings you the greatest pleasure?",
        "If you could, would you go back 10 years in your life? Why or why not?",
        "What is a situation that always makes you procrastinate?",
        "What country would you like to visit for the first time?",
        "Plan your last meal—make it as elaborate and complicated as you wish!"
            };
    public string WritingPrompt()
    {
        var rdm = new Random();
        var randomIndex = rdm.Next(prompts.Count());
        return prompts[randomIndex];
    }
}
class saveFile
{
    public void Save(List<string> entries)
    {
        Console.WriteLine("Please enter the file name you want to save");
        Console.Write("> ");
        string fileName = Console.ReadLine() ?? "UnamedFile";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string word in entries)
            {
                outputFile.WriteLine($"{word}");
            };
        }
    }
}

class loadFile
{
    List<string> entries = new List<string> { };
    public List<string> load(string name)
    {

        string filename = name;
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            entries.Add(line);
        }
        return entries;
    }
}
