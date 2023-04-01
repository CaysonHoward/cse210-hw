using System;

class Profile{
    private string _Name;
    private int _HrsSty = 0;
    private int _MinSty = 0;
    private int _SecSty = 0;

    public Profile(string name, int hours, int min, int sec)
    {
        _Name = name;
        _HrsSty = hours;
        _MinSty = min;
        _SecSty = sec;
    }
    public void Welcome(){
        Console.WriteLine($"Hello {_Name}!");
    }
    public void ChangeName(){
        Console.WriteLine($"Your name is currently {_Name}");
        Console.WriteLine("What would you like to change to to?");
        Console.Write(">");
        string newName = Console.ReadLine();
        _Name = newName;
        Console.WriteLine($"Hello {_Name}!");
    }
    public void timeStudied()
    {
        Console.WriteLine($"For {_Name}, you have spend {_HrsSty} hours, {_MinSty} minutes and {_SecSty} seconds studing");
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
    public void savedata(){
        using (StreamWriter outputFile = new StreamWriter("UserInfo.txt"))
            {
                outputFile.WriteLine(_Name);
                outputFile.WriteLine(_HrsSty);
                outputFile.WriteLine(_MinSty);
                outputFile.WriteLine(_SecSty);
            }
    }
}