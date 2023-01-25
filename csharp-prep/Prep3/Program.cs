using System;

class Program
{
    static void Main(string[] args)
    {
        Random generator = new Random();
        int MagicNumber = generator.Next(1,11);

        bool KeepPlaying = true;
        
        while (KeepPlaying){
            Console.Write("Guess a number between 1 and 10: ");
            int UserGuess = int.Parse(Console.ReadLine() ?? "");

            if (MagicNumber == UserGuess)
            {
                Console.WriteLine("You guessed it correctly!");
                KeepPlaying = false;
            } else if (MagicNumber > UserGuess){
                Console.WriteLine("Higher");
            } else {
                Console.WriteLine("Lower");
            }
        }
    }
}