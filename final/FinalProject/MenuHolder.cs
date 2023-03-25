using System;

class MenuHolder{
    //Consider adding a console clear to the end of each menu to make navigating the overall program simpler
    public int MainMenu(){
        Console.WriteLine("Welcome to the student study tracking app!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Start a study session");
        Console.WriteLine("2. View Schedual");
        Console.WriteLine("3. Manage Classes");
        Console.WriteLine("4. View Profile");
        Console.WriteLine("5. Quit");

        Console.Write(">");
        //Insert error cheacking mecanics. Make sure that the input can accent letters without crashing and
        //handle numbers outside the menu choices
        int userchoice = int.Parse(Console.ReadLine());
        return userchoice;
    }
    public int StudySessionMenu(){
        Console.WriteLine("Welcome to study sessions!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Start a study session");
        Console.WriteLine("2. View past study sessions");
        Console.WriteLine("3. View total hours this week");
        Console.WriteLine("4. Return");
        
        Console.Write(">");
        //Insert error cheacking mecanics. Make sure that the input can accent letters without crashing and
        //handle numbers outside the menu choices
        int userchoice = int.Parse(Console.ReadLine());
        return userchoice;
    }
    public int SchedualMenu(){
        Console.WriteLine("Welcome to your Schedual!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. View current week");
        Console.WriteLine("2. View past weeks");
        Console.WriteLine("3. Return");

        Console.Write(">");
        //Insert error cheacking mecanics. Make sure that the input can accent letters without crashing and
        //handle numbers outside the menu choices
        int userchoice = int.Parse(Console.ReadLine());
        return userchoice;
    }
    public int ClassMenu(){
        Console.WriteLine("Welcome to the Class Manager");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. View Classes");
        Console.WriteLine("2. Add Class");
        Console.WriteLine("3. Remove Class");
        Console.WriteLine("4. Modify Class");
        Console.WriteLine("5. Return");

        Console.Write(">");
        //Insert error cheacking mecanics. Make sure that the input can accent letters without crashing and
        //handle numbers outside the menu choices
        int userchoice = int.Parse(Console.ReadLine());
        return userchoice;
    }
    public int ProfileMenu(){
        Console.WriteLine("Welcome to your profile");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. View Total hours studied");
        Console.WriteLine("2. View Info");
        Console.WriteLine("3. Return");

        Console.Write(">");
        //Insert error cheacking mecanics. Make sure that the input can accent letters without crashing and
        //handle numbers outside the menu choices
        int userchoice = int.Parse(Console.ReadLine());
        return userchoice;
    }
}