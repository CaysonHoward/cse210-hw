using System;

class Reference
{
    
    private string _book;
    private string _Chapter; 
    private string _startVerse;
    private string _endVerse;

    public void addReference(string book, string chapter, string startVerse, string endVerse){
        _book = book;
        _Chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public void createReference(){
        if (_endVerse == null){ 
            Console.Write($"{_book} {_Chapter}:{_startVerse} ");
        }
        else{
            Console.Write($"{_book} {_Chapter}:{_startVerse}-{_endVerse} ");
        }
        
    }
}