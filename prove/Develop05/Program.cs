using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> userGoals = new List<Goal>();
        ProgramLoader loader = new ProgramLoader();
        userGoals = loader.LoadGoals();
        UserProfile user = loader.loadUser();
        GoalCreation goalcreator = new GoalCreation();
        Menus menus = new Menus();

        int UserChoice = 0;

        user.HelloUser();
        while (UserChoice != 5)
        {
            UserChoice = menus.MainMenu();

            if (UserChoice == 1)
            {
                user.viewProfile();
            }
            if (UserChoice == 2)
            {
                foreach(Goal g in userGoals){
                    g.viewInfo();
                }
            }
            if (UserChoice == 3)
            {
                int userGoalCreate = menus.GoalCreationMenu();
                if(userGoalCreate == 1){
                    userGoals.Add(goalcreator.CreateSimpleGoal());
                }
                if(userGoalCreate == 2){
                    userGoals.Add(goalcreator.CreatelistGoal());
                }
                if(userGoalCreate == 3){
                    userGoals.Add(goalcreator.CreateNeverendingGoal());
                }
            }
            if (UserChoice == 4)
            {
                int goalnum = 1;
                Console.WriteLine("Here is a numbered list of all your goals");
                foreach(Goal g in userGoals){
                    Console.WriteLine($"#{goalnum}");
                    g.viewInfo();
                    goalnum += 1;
                }
                Console.WriteLine("Please select which goal you would like to update progress on");
                int usergoal = int.Parse(Console.ReadLine());
                user.earnPoints(userGoals[usergoal - 1].ToComplete());
            }
            loader.SaveGoals(userGoals, user);
        }

    }
}