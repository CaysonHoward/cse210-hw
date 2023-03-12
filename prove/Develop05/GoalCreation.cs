using System;

class GoalCreation
{

    public Goal CreateSimpleGoal()
    {
        Console.WriteLine("Create a Simple Goal!");
        Console.Write("What is the name of this goal? ");
        string name = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        int value = int.Parse(Console.ReadLine());
        int comp = 0;
        SimpleGoal newgoal = new SimpleGoal(name, value, comp, 0);
        Console.WriteLine("Goal Created");
        return newgoal;



    }
    public Goal CreatelistGoal()
    {
        Console.WriteLine("Create a List Goal!");
        Console.Write("What is the name of this goal? ");
        string name = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("How many times to compleate the goal? ");
        int ctf = int.Parse(Console.ReadLine());
        int comp = 0;
        ListGoal newgoal = new ListGoal(name, value, comp, ctf, 0);
        Console.WriteLine("Goal Created");
        return newgoal;
    }
    public Goal CreateNeverendingGoal()
    {
        Console.WriteLine("Create a Neverending Goal!");
        Console.Write("What is the name of this goal? ");
        string name = Console.ReadLine();
        Console.Write("How many points is the goal worth? ");
        int value = int.Parse(Console.ReadLine());
        int comp = 0;
        NeverendingGoal newgoal = new NeverendingGoal(name, value, comp, 0);
        Console.WriteLine("Goal Created");
        return newgoal;

    }
}