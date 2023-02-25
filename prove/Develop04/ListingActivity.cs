using System;

class ListingActivity : Activity
{
    private List<string> prompt = new List<string>();
    Random rnd = new Random();


    public ListingActivity()
    {
        _activityName = "Listening Activity";
        _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        initlisting();
    }
    public void runListeningActivity()
    {
        ActivityDescription();
        GetUserInput();
        startActivity();
        listeningExercise();
        EndingMessage();

    }
    private void initlisting()
    {
        prompt.Add("Who are people that you appreciate?");
        prompt.Add("What are personal strengths of yours?");
        prompt.Add("Who are people that you have helped this week?");
        prompt.Add("When have you felt the Holy Ghost this month?");
        prompt.Add("Who are some of your personal heroes?");
    }

    private void listeningExercise()
    {
        Console.WriteLine("list as many responses to the following prompt\n");
        int rndNumprompt = rnd.Next(0, 5);
        Console.WriteLine($"-----   {prompt[rndNumprompt]}   -----");
        Console.Write("List as many items as you can: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        int time = GetTime();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        string item;

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime){
            Console.Write(">");
            item = Console.ReadLine() ?? "";
            currentTime = DateTime.Now;
        }
    }


}