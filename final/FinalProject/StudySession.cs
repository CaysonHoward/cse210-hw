using System;

class StudySession : SimpleTimer
{

    public void StudyTime(List<SchoolClass> classes, Profile user)
    {
        TimeSpan dt = timer();
        int classnum = 1;
        Console.WriteLine("What class would you like to add time to?");
        foreach (SchoolClass c in classes)
        {
            Console.Write($"{classnum}.");
            c.displayName();
            classnum += 1;
        }
        Console.Write(">");
        int modclass = int.Parse(Console.ReadLine());
        classes[modclass - 1].addTime(dt.Hours, dt.Minutes, dt.Seconds);
        user.addTime(dt.Hours, dt.Minutes, dt.Seconds);

    }

}