using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _activityName = "Breathing Activity";
        _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingActivity()
    {

        ActivityDescription();
        GetUserInput();
        startActivity();
        breathingExercise();
        EndingMessage();

    }

    private void breathingExercise()
    {
        int length = GetTime();
        int remainder = length % 10;
        Console.WriteLine(remainder);
        int tenseconds = (length - remainder) / 10;
        int loop = 0;

        while (loop != tenseconds)
        {
            Console.Write("\n\nBreathe in ... ");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the + character
            }
            Console.Write("\nBreathe out ...");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b"); // Erase the + character
            }
            loop += 1;
        }

        
        Console.Write("\n\nBreathe in ... ");
        for (int i = (remainder / 2); i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
        Console.Write("\nBreathe out ...");
        for (int i = (remainder / 2); i >= 1; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the + character
        }
    }

}