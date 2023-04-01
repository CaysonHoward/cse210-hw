using System;

class ClassCreator{
    public SchoolClass createSchoolClass(){
        Console.WriteLine("What is this classes name?");
        Console.Write(">");
        string userchoice = Console.ReadLine();
        Console.WriteLine("How many credits is this class?");
        Console.Write(">");
        int usercredits = int.Parse(Console.ReadLine());
        SchoolClass schoolclass = new SchoolClass(userchoice, usercredits, 0,0,0);
        return schoolclass;
    }
}