using System;

class Goal
{
    protected string _GoalName;
    protected int _Value;
    protected int _TimesCompleted;
    protected int _completionsToFinish;
    protected bool _compleated;

    public virtual int ToComplete()
    {
        Console.WriteLine("How many time did you do this goal?");
        int attempts = int.Parse(Console.ReadLine());
        _TimesCompleted += attempts;
        if (_TimesCompleted >= _completionsToFinish)
        {
            return _Value;
        }
        else
        {
            return 0;
        }
    }
    public void viewInfo()
    {
        Console.WriteLine("------------------------");
        if (_compleated == false) { Console.WriteLine($"Finshed [ ]"); } else { Console.WriteLine($"Finshed [X]"); }
        Console.WriteLine($"Name: {_GoalName}");
        Console.WriteLine($"Points: {_Value}");
        Console.WriteLine($"Times Compleated: {_TimesCompleted}");
        if (_completionsToFinish > 0) { Console.WriteLine($"Times to finsh: {_completionsToFinish}"); }
        Console.WriteLine();
    }
    public List<string> saveGoal()
    {
        List<string> data = new List<string>();
        string Compleated;
        data.Add(_GoalName);
        data.Add(_Value.ToString());
        data.Add(_TimesCompleted.ToString());
        data.Add(_completionsToFinish.ToString());
        if (_compleated == true) {Compleated = "1";} else { Compleated =  "0";} 
        data.Add(Compleated);
        return data;
    }
}