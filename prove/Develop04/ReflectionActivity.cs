using System;

class ReflectionActivity : Activity
{
    private List<string> prompt = new List<string>();
    private List<string> reflection = new List<string>();
    Random rnd = new Random();
    public ReflectionActivity()
    {
        initReflection();
        _activityName = "Reflection Activity";
        _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void runRelectionActivity()
    {
        ActivityDescription();
        GetUserInput();
        startActivity();
        reflectionExercise();
        EndingMessage();

    }
    private void initReflection()
    {
        prompt.Add("Think of a time when you stood up for someone else.");
        prompt.Add("Think of a time when you did something really difficult.");
        prompt.Add("Think of a time when you helped someone in need.");
        prompt.Add("Think of a time when you did something truly selfless.");

        reflection.Add("Why was this experience meaningful to you?");
        reflection.Add("Have you ever done anything like this before?");
        reflection.Add("How did you get started?");
        reflection.Add("How did you feel when it was complete?");
        reflection.Add("What made this time different than other times when you were not as successful?");
        reflection.Add("What is your favorite thing about this experience?");
        reflection.Add("What could you learn from this experience that applies to other situations?");
        reflection.Add("What did you learn about yourself through this experience?");
        reflection.Add("How can you keep this experience in mind in the future?");
    }

    private void reflectionExercise()
    {
        Console.WriteLine("Consider the following prompt\n");
        int rndNumprompt = rnd.Next(0, 5);
        Console.WriteLine($"-----   {prompt[rndNumprompt]}   -----");
        Console.WriteLine("When you have something in mind, press enter");
        string stop = Console.ReadLine() ?? " ";
        Console.WriteLine("Now please ponder the each of the following questions related to this experience.");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        int time = (GetTime()) - 5;
        Console.Clear();
        int rndNumref = rnd.Next(0, 10);
        Console.WriteLine(reflection[rndNumref]);
        Thread.Sleep(5000);
        for (int i = time; i > 0; i--)
        {
            if (i % 10 == 0){
                Console.WriteLine(reflection[rndNumref]);
            }
            Thread.Sleep(1000);
        }
        
    }

}