using System;

class UserProfile
{
    private int _Points;
    private int _Level;
    private string _Name;
    private int _pointsToNext;
    public UserProfile(string name, int level, int points){
        _Name = name;
        _Level = level;
        _Points = points;
        _pointsToNext = pointsForNextLevel();
    }

    public void HelloUser()
    {
        Console.WriteLine($"Hello {_Name}!");
        Console.WriteLine($"You are currently level {_Level}");
    }
    public void viewProfile()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine($"Level: {_Level}");
        Console.WriteLine($"Points {_Points}/{_pointsToNext}");
    }
    public void earnPoints(int pointsEarned){
        _Points += pointsEarned;
        while (_Points >= _pointsToNext)
        {   
            levelUp();
            _pointsToNext = pointsForNextLevel();
        }
    }
    public void savedata(){
            using (StreamWriter outputFile = new StreamWriter("UserInfo.txt"))
            {
                outputFile.WriteLine(_Name);
                outputFile.WriteLine(_Level);
                outputFile.WriteLine(_Points);
            }
    }
    private int pointsForNextLevel()
    {
        return (_Level * 50) + 20;
    }
    private void levelUp(){
        Console.WriteLine($"Congradulations {_Name}! You have leveled up!");
        _Level += 1;
        _Points -= _pointsToNext;

    }


}