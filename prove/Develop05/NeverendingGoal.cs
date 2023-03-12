using System;

class NeverendingGoal : Goal
{
    public NeverendingGoal(string name, int value, int completions, int comp){
        _GoalName = name;
        _Value = value;
        _TimesCompleted = completions;
        _completionsToFinish = 0;
        if(comp == 1){
            _compleated = true;
        }
        else{
            _compleated = false;
        }

    }
    public override int ToComplete()
    {
        Console.WriteLine("How many time did you do this goal?");
        int attempts = int.Parse(Console.ReadLine());
        _TimesCompleted += attempts;
        return _Value * attempts;

    }
}