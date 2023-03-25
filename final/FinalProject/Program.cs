using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare and create
        MenuHolder menus = new MenuHolder();
        StudySession study = new StudySession();

        //Set/initalize variable and program

        //Begin program running
        int UserMenuChoice = 1;
        while (UserMenuChoice != 5)
        {
            UserMenuChoice = menus.MainMenu();
            if (UserMenuChoice == 1)
            {
                UserMenuChoice = menus.StudySessionMenu();
                if (UserMenuChoice == 1)
                {
                    study.StudyTime();
                }
                if (UserMenuChoice == 2)
                {
                    //View Past Study Sessions
                }
                if (UserMenuChoice == 3)
                {
                    //View total hours
                }
            }
            if (UserMenuChoice == 2)
            {
                UserMenuChoice = menus.SchedualMenu();
                if (UserMenuChoice == 1)
                {
                    //View Weekly Schedual
                }
                if (UserMenuChoice == 2)
                {
                    //View Past Weeks
                }
            }
            if (UserMenuChoice == 3)
            {
                UserMenuChoice = menus.ClassMenu();
                if (UserMenuChoice == 1)
                {
                    //View Classes
                }
                if (UserMenuChoice == 2)
                {
                    //Add Classes
                }
                if (UserMenuChoice == 3)
                {
                    //Remove Class
                }
                if (UserMenuChoice == 4)
                {
                    //Modify Class
                }
            }
            if (UserMenuChoice == 4)
            {
                UserMenuChoice = menus.ClassMenu();
                if (UserMenuChoice == 1)
                {
                    //View total hours studied
                }
                if (UserMenuChoice == 2)
                {
                    //View Profile info
                }
            }
            
        }
    }
}