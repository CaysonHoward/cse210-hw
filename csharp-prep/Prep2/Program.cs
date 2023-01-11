using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage ");
        string TextGrade = Console.ReadLine() ?? "";

        int IntGrade = int.Parse(TextGrade);
        bool passed = true;
        string Letter = "";

        if (IntGrade >= 90){
            Letter = "A";
        }
        else if (IntGrade >= 80){
            Letter = "B";
        }
        else if (IntGrade >= 70){
            Letter = "C";
        }
        else if (IntGrade >= 60){
            Letter = "D";
            passed = false;
        }
        else{
            Letter = "F";
            passed = false;
        }

        Console.WriteLine($"You got an {Letter}");

        if (passed == true){
            Console.WriteLine("Great job! You passed the class?");
        }
        else {
            Console.WriteLine("Sorry, you did not pass. Try again!");
        }
    }
}