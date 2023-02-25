using System;

class Activity
{
    protected string _activityDescription;
    protected string _activityName;
    private int _activityLength;
    public void ActivityDescription()
    {
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine(_activityDescription);
    }
    public void GetUserInput()
    {
        Console.WriteLine("How long in seconds would you like to do this activity for?");
        Console.Write("> ");
        string input = Console.ReadLine() ?? "10";
        _activityLength = int.Parse(input);
    }
    public int GetTime(){
        return _activityLength;
    }
    public void EndingMessage()
    {
        Console.WriteLine("Well done!\n");
        spinnerAnimation(3);
        Console.WriteLine($"You have completed a {_activityName} that lasted {_activityLength} Seconds\n");

    }
    public void startActivity()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        spinnerAnimation(4);
    }
    public void spinnerAnimation(int length)

    {
        int animationTime = 0;
        while (animationTime < length)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character

            animationTime += 1;
        }

    }
}