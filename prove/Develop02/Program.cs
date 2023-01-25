using System;

class Program
{
    static void Main(string[] args){
        int UserChoice = 0;
        Menu menu = new Menu();

        while (UserChoice != 5){
            menu.Display();
            string MenuChoice = Console.ReadLine() ?? "5";
            UserChoice = int.Parse(MenuChoice);

            if (UserChoice == 1){
                Console.WriteLine("Working");
            }
        }
    }
}

class Menu{
    public void Display(){
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

class Prompt{
    List<string> prompts = new List<string>();

    Prompt(){
        
    }
}