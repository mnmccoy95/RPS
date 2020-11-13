using System;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0;
            int compScore = 0;
            Play(playerScore, compScore);
        }

        static void Play(int playerScore, int compScore)
        {
            Console.WriteLine($@"
            ---------------------------
            | Player: {playerScore} | Computer: {compScore} |
            ---------------------------
            What would you like to throw?
            1) Rock
            2) Paper
            3) Scissors
            ");
        }
    }
}
