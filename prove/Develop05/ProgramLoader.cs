using System;

class ProgramLoader
{
    public void SaveGoals(List<Goal> goals, UserProfile user)
    {
        List<string> data = new List<string>();
        foreach (Goal g in goals)
        {
            data.AddRange(g.saveGoal());
        }
        
        using (StreamWriter outputFile = new StreamWriter("goals.txt"))
            {
                outputFile.WriteLine("Start:");
                foreach (string s in data)
                {
                    outputFile.WriteLine(s);
                }
            }
        user.savedata();
    }
    public List<Goal> LoadGoals()
    {
        if (!File.Exists("Goals.txt"))
        {
            using (StreamWriter outputFile = new StreamWriter("Goals.txt"))
            {
                outputFile.WriteLine("Start:");
            }
        }

        List<Goal> userGoals = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines("Goals.txt");
        int total_goals = lines.Length;
        if (total_goals < 5)
        {
            return userGoals;
        }
        total_goals = (total_goals / 5) + 1;
        int goalsLoad = 1;
        int goalsLoaded = 0;
        while (goalsLoad != total_goals)
        {
            if (int.Parse(lines[4 + goalsLoaded]) == 0)
            {
                NeverendingGoal newgoal = new NeverendingGoal(lines[1 + goalsLoaded], int.Parse(lines[2 + goalsLoaded]), int.Parse(lines[3 + goalsLoaded]), int.Parse(lines[5 + goalsLoaded]));
                userGoals.Add(newgoal);
            }
            if (int.Parse(lines[4 + goalsLoaded]) == 1)
            {
                SimpleGoal newgoal = new SimpleGoal(lines[1 + goalsLoaded], int.Parse(lines[2 + goalsLoaded]), int.Parse(lines[3 + goalsLoaded]), int.Parse(lines[5 + goalsLoaded]));
                userGoals.Add(newgoal);
            }
            if (int.Parse(lines[4 + goalsLoaded]) > 1)
            {
                ListGoal newgoal = new ListGoal(lines[1 + goalsLoaded], int.Parse(lines[2 + goalsLoaded]), int.Parse(lines[3 + goalsLoaded]), int.Parse(lines[4 + goalsLoaded]), int.Parse(lines[5 + goalsLoaded]));
                userGoals.Add(newgoal);

            }
            goalsLoaded += 5;
            goalsLoad += 1;
        }
        foreach(Goal g in userGoals){
            g.viewInfo();
        }
        return userGoals;


    }
    public UserProfile loadUser()
    {
        string userfile = "Nevermind/UserInfo.txt";
        if (!File.Exists(userfile))
        {

            using (StreamWriter outputFile = new StreamWriter(userfile))
            {
                Console.Write("What is your name? ");
                string userName = Console.ReadLine();
                outputFile.WriteLine(userName);
                outputFile.WriteLine("1");
                outputFile.WriteLine("0");
            }
        }
        string[] lines = System.IO.File.ReadAllLines(userfile);
        UserProfile user = new UserProfile(lines[0], int.Parse(lines[1]), int.Parse(lines[2]));
        return user;

    }
}