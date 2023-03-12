class Program
{
    static void Main(string[] args)
    {

    }
}

class Employee{
    int Salary = 1000000;
    virtual public int calculateYearlyPay(){
        return Salary;
    }
}
class HourlyEmployee : Employee{
    int HourlyWage = 25;
    int HoursPerYear = 2000;

    public override int calculateYearlyPay()
    {
        return HourlyWage * HoursPerYear;
    }

}