using System;

class Menus{

    public int MainMenu(){      
        Console.WriteLine("Main Menu:");
        Console.WriteLine("1. View Profile");
        Console.WriteLine("2. View Active Goals");
        Console.WriteLine("3. Create New Goal");
        Console.WriteLine("4. Record Goal advancment");
        Console.WriteLine("5. Quit");
        Console.Write("> ");

        int MenuChoice = int.Parse(Console.ReadLine());

        return MenuChoice;


    }
    public int GoalCreationMenu()
    {
        Console.WriteLine("What kind of Goal would you like to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. List Goal");
        Console.WriteLine("3. Eternal Goal");
        Console.WriteLine("4. Exit");

        int MenuChoice = int.Parse(Console.ReadLine());

        return MenuChoice;
    }

}