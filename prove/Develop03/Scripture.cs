using System;

class Scripture
{
    public List<word> scriptureWords = new List<word>();
    Random rnd = new Random();

    
    public void scriptureDisplay(){
        foreach (word i in scriptureWords){
                i.displayWord();
        }
    }

    //create function that hides random words
    public void hideWords(){
        Random rnd = new Random();
        int hideWord = 0;
        int wordsHidden = 0;
        while (wordsHidden != 3){
            hideWord = rnd.Next(0, scriptureWords.Count());
            bool wordHidden = scriptureWords[hideWord].hide();

            if (wordHidden == true){
                wordsHidden += 1;
                if(allWordsHidden() == true){
                    wordsHidden = 3;
                }
            }
        }
    }
    public bool allWordsHidden(){
        foreach(word i in scriptureWords){
            if(i.isHidden() == false){
                return false;
            }
        }
        return true;
    }

}