using System;

class SchoolClass
{
    //This will have total credits and time studied
    //This will also contain a simple method on how to load and save class info?

    private string _Name;
    private int _Credits;
    private int _HrsSty = 0;
    private int _MinSty = 0;
    private int _SecSty = 0;

    public SchoolClass(string name, int credits, int hours, int min, int sec)
    {
        _Name = name;
        _Credits = credits;
        _HrsSty = hours;
        _MinSty = min;
        _SecSty = sec;
    }

    public void addTime(int hour, int min, int sec)
    {
        _SecSty += sec;
        if (_SecSty >= 60)
        {
            _SecSty -= 60;
            _MinSty += 1;
        }
        _MinSty += min;
        if (_MinSty >= 60)
        {
            _MinSty -= 60;
            _HrsSty += 1;
        }
        _HrsSty += hour;

    }

    public void displayInfo()
    {
        Console.WriteLine($"You are taking {_Name}");
        Console.WriteLine($"This class is {_Credits}");
        Console.WriteLine($"You have spend {_HrsSty} hours, {_MinSty} minutes and {_SecSty} seconds studing for this class");
        Console.WriteLine($"It is recommended you spend {(_Credits * 3) * 14} total hours per semester studing for this class");

    }
    public void timeStudied()
    {
        Console.WriteLine($"For {_Name}, you have spend {_HrsSty} hours, {_MinSty} minutes and {_SecSty} seconds studing");
    }
    public void displayName()
    {
        Console.WriteLine($"{_Name}");
    }
    public void ChangeName()
    {
        Console.WriteLine($"The current class name is {_Name}");
        Console.WriteLine("What would you like to change it too?");
        Console.Write(">");
        string newName = Console.ReadLine();
        Console.WriteLine($"{_Name} has been changed to {newName}");
        _Name = newName;
    }
    public void ChangeCredits()
    {
        Console.WriteLine($"For {_Name}, the current credit amount is {_Credits}");
        Console.WriteLine("How would you like to change it too?");
        Console.Write(">");
        int newCred = int.Parse(Console.ReadLine());
        Console.WriteLine($"{_Name} credit amount has been changed to {newCred}");
        _Credits = newCred;
    }
    public List<string> saveClass()
    {
        List<string> data = new List<string>();
        data.Add(_Name);
        data.Add(_Credits.ToString());
        data.Add(_HrsSty.ToString());
        data.Add(_MinSty.ToString());
        data.Add(_SecSty.ToString());
        return data;
    }

}