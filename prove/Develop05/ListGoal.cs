using System;

class ListGoal : Goal{
    public ListGoal(string name, int value, int completions, int ctf, int comp){
        _GoalName = name;
        _Value = value;
        _TimesCompleted = completions;
        _completionsToFinish = ctf;
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
        if(_TimesCompleted >= _completionsToFinish){
            _compleated = true;
            return _Value;
        }
        else{
            return _Value / 10;
        }
    }
}