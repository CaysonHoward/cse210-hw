using System;

class Program
{
    static void Main(string[] args)
    {
        Person personOne = new Person();

        personOne._firstName = "Cayson";
        personOne._lastName = "Howard";

        personOne.printName();
    }
}

class Person
{
    public string _firstName;
    public string _lastName;

    public void printName(){
        Console.WriteLine($"{_firstName} {_lastName}");
    }

}