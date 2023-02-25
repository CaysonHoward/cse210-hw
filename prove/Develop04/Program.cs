using System;

class Program
{
    static void Main(string[] args)
    {
        int UserMenuChoice = 0;
        BreathingActivity breathing = new BreathingActivity();
        ListingActivity listing = new ListingActivity();
        ReflectionActivity reflection = new ReflectionActivity();

        while (UserMenuChoice != 4)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listening Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            UserMenuChoice = int.Parse(Console.ReadLine() ?? "4");

            if (UserMenuChoice == 1)
            {
                breathing.RunBreathingActivity();
            }
            else if (UserMenuChoice == 2)
            {
                reflection.runRelectionActivity();
            }
            else if(UserMenuChoice == 3)
            {
                listing.runListeningActivity();
            }
        }
    }
}