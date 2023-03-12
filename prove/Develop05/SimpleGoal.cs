using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string name, int value, int completions, int comp){
        _GoalName = name;
        _Value = value;
        _TimesCompleted = completions;
        _completionsToFinish = 1;
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
        if(attempts == 0){
            return 0;
        }
        if(_TimesCompleted >= _completionsToFinish){
            _compleated = true;
            return _Value;
        }
        else{
            return _Value / 10;
        }
    }
}