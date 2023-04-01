using System;

class Program
{
    static void Main(string[] args)
    {
        //Declare and create
        MenuHolder menus = new MenuHolder();
        StudySession study = new StudySession();
        ClassCreator createclass = new ClassCreator();
        List<SchoolClass> classes = new List<SchoolClass>();
        ProgramSaver save = new ProgramSaver();
        ProgramLoader load = new ProgramLoader();
        Profile user = load.loadUser();


        //Set and initalize variables and classes
        classes = load.loadData();
        //Begin program running
        int UserMenuChoice = 1;
        Console.WriteLine("Welcome to the student study tracking app!");
        while (UserMenuChoice != 4)
        {
            UserMenuChoice = menus.MainMenu();
            if (UserMenuChoice == 1)
            {
                int StudyMenuChoice = menus.StudySessionMenu();
                if (StudyMenuChoice == 1)
                {
                    study.StudyTime(classes, user);
                }
                if (StudyMenuChoice == 2)
                {
                    foreach (SchoolClass c in classes)
                    {
                        c.timeStudied();
                    }
                }
            }
            if (UserMenuChoice == 2)
            {
                int ClassMenuChoice = menus.ClassMenu();
                if (ClassMenuChoice == 1)
                {
                    foreach (SchoolClass c in classes)
                    {
                        c.displayInfo();
                    }
                }
                if (ClassMenuChoice == 2)
                {
                    classes.Add(createclass.createSchoolClass());
                }
                if (ClassMenuChoice == 3)
                {
                    int classnum = 1;
                    foreach (SchoolClass c in classes)
                    {
                        Console.Write($"{classnum}. ");
                        c.displayInfo();
                        classnum += 1;
                    }
                    Console.WriteLine("Please enter the number of the class you wish to remove or 0 to exit");
                    Console.Write(">");
                    int delclass = int.Parse(Console.ReadLine());
                    if (delclass != 0)
                    {
                        classes.RemoveAt(delclass - 1);
                    }
                }
                if (ClassMenuChoice == 4)
                {
                    int classnum = 1;
                    foreach (SchoolClass c in classes)
                    {
                        Console.Write($"{classnum}. ");
                        c.displayInfo();
                        classnum += 1;
                    }
                    Console.WriteLine("Please enter the number of the class you wish to modify");
                    Console.Write(">");
                    int modclass = int.Parse(Console.ReadLine());
                    Console.WriteLine("Press 1 to modify the name, and two to modify credits.");
                    Console.Write(">");
                    int cngclass = int.Parse(Console.ReadLine());

                    if (cngclass == 1)
                    {
                        classes[modclass - 1].ChangeName();
                    }
                    if (cngclass == 2)
                    {
                        classes[modclass - 1].ChangeName();
                    }
                }
            }
            if (UserMenuChoice == 3)
            {
                int ProfileMenuChoice = menus.ProfileMenu();
                if (ProfileMenuChoice == 1)
                {
                    user.timeStudied();
                }
                if (ProfileMenuChoice == 2)
                {
                    user.ChangeName();
                }
            }
            save.SaveData(classes);
            save.SaveProfile(user);
        }
    }
}