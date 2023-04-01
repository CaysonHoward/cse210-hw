using System;

class ProgramLoader
{
    //This will hold constructiors for the required classes and call their load functions to load the functions

    public List<SchoolClass> loadData()
    {
        if (!File.Exists("classes.txt"))
        {
            using (StreamWriter outputFile = new StreamWriter("classes.txt"))
            {
            }
        }

        List<SchoolClass> schoolclass = new List<SchoolClass>();
        string[] lines = System.IO.File.ReadAllLines("classes.txt");
        int total_lines = lines.Length;
        if (total_lines <= 4)
        {
            return schoolclass;
        }
        int total_classes = (total_lines / 5);
        int classesLoad = 0;
        int classesLoaded = 0;
        while (classesLoad != total_classes)
        {
            SchoolClass Sclass = new SchoolClass(lines[0 + classesLoaded], int.Parse(lines[1 + classesLoaded]), int.Parse(lines[2 + classesLoaded]), int.Parse(lines[3 + classesLoaded]), int.Parse(lines[4 + classesLoaded]));
            schoolclass.Add(Sclass);
            classesLoaded += 5;
            classesLoad += 1;
        }
        return schoolclass;
    }
        public Profile loadUser()
    {
        string userfile = "UserInfo.txt";
        if (!File.Exists(userfile))
        {

            using (StreamWriter outputFile = new StreamWriter(userfile))
            {
                Console.Write("What is your name? ");
                string userName = Console.ReadLine();
                outputFile.WriteLine(userName);
                outputFile.WriteLine("0");
                outputFile.WriteLine("0");
                outputFile.WriteLine("0");
            }
        }
        string[] lines = System.IO.File.ReadAllLines(userfile);
        Profile user = new Profile(lines[0], int.Parse(lines[1]), int.Parse(lines[2]), int.Parse(lines[3]));
        return user;

    }
}