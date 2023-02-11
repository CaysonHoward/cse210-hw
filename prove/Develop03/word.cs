using System;

class word
{
    public word(string word){
        _sWord = word;
    }
    private string _sWord;
    
    private bool _isHidden = false;

    public void displayWord(){
            Console.Write(_sWord + " ");
    }
    public bool hide(){
        if(_isHidden == false){
            _isHidden = true;
            string wordReplace = "";
            foreach(char c in _sWord){
                wordReplace += "_";
                
            }
            _sWord = wordReplace;
            return true;
        }
        else{
            return false;
        }
    }
    public bool isHidden(){
        if (_isHidden == true){
            return true;
        }
        else{
            return false;
        }
    }

}