using System;

class Storage{
    private List<string> scripture = new List<string>();
    private List<string> book = new List<string>();
    private List<string> chapter = new List<string>();
    private List<string> startVerse = new List<string>();
    private List<string> endVerse = new List<string>();

    //get random number for references gathering

    public void initScriptures(){
        book.Add("Proverbs");
        chapter.Add("3");
        startVerse.Add("5");
        endVerse.Add("6");
        scripture.Add("Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        book.Add("Isaiah");
        chapter.Add("5");
        startVerse.Add("20");
        endVerse.Add(null);
        scripture.Add("Woe unto them that call evil good, and good evil; that put darkness for light, and light for darkness; that put bitter for sweet, and sweet for bitter!");

        book.Add("2 Nephi");
        chapter.Add("28");
        startVerse.Add("30");
        endVerse.Add(null);
        scripture.Add("For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have.");

        book.Add("Doctrine and Covenants");
        chapter.Add("8");
        startVerse.Add("2");
        endVerse.Add("3");
        scripture.Add("Yea, behold, I will tell you in your mind and in your heart, by the Holy Ghost, which shall come upon you and which shall dwell in your heart. Now, behold, this is the spirit of revelation; behold, this is the spirit by which Moses brought the children of Israel through the Red Sea on dry ground.");

    }

    public List<string> returnScripture(int rand){
        //return scripture and book
        List<string> reference = new List<string>();

        reference.Add(book[rand]);
        reference.Add(chapter[rand]);
        reference.Add(startVerse[rand]);
        reference.Add(endVerse[rand]);
        reference.Add(scripture[rand]);

        return reference;
    }

}