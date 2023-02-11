class Program {
    static void Main(string[] args) {
        
        var divider =  new IntegerDivision();
        divider.lhs = 10;
        divider.rhs = 1;
        divider.DisplayResult();

        divider.lhs = 0;
        divider.rhs = 100;
        divider.DisplayResult();

        divider.lhs = 5;
        divider.rhs = 0;
        divider.DisplayResult();

        divider.lhs = 25;
        divider.rhs = 5;
        divider.DisplayResult();
    }
}

class IntegerDivision {
    private int _lhs;
    public int lhs { 
        get {return _lhs;} 
        set {_lhs = (_lhs != 0 ? _lhs : zeroHandler());} 
        }

    private int _rhs;
    public int rhs { 
        get {return _rhs;} 
        set {_rhs = (rhs != 0 ? rhs : zeroHandler()); } 
        }

    private int zeroHandler(){
        Console.Write("Can't divide by zero. It has been replaced with a one.   ");
        return 1;
    }
    public int Result() {
        return _lhs / _rhs;
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{lhs} divided by {rhs} is {result}");
    }
}
