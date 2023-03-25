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
        int UserMenuChoice = menus.MainMenu();
        if (UserMenuChoice == 1)
        {
            UserMenuChoice = menus.StudySessionMenu();
            if (UserMenuChoice == 1)
            {
                study.StudyTime();
            }
        }
    }
}