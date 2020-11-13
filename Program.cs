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
            if(playerScore != 3 && compScore != 3)
            {
            Console.Write($@"
            ---------------------------
            | Player: {playerScore} | Computer: {compScore} |
            ---------------------------
            What would you like to throw?
            1) Rock
            2) Paper
            3) Scissors
            ");

            int answer = Int32.Parse(Console.ReadLine());
            int compAnswer = Number();

            Compare(answer, compAnswer, playerScore, compScore);
            }
        }

        static int Number() {
            Random r = new Random();
            int genRand= r.Next(1,3);
            return genRand;
        }

        static void Compare(int playerAnswer, int compAnswer, int playerScore, int compScore)
        {
            if(playerAnswer == 1)
            {
                if(compAnswer == 2)
                {
                    compScore++;
                }
                if(compAnswer == 3)
                {
                    playerScore++;
                }
            }

            if(playerAnswer == 2)
            {
                if(compAnswer == 3)
                {
                    compScore++;
                }
                if(compAnswer == 1)
                {
                    playerScore++;
                }
            }

            if(playerAnswer == 3)
            {
                if(compAnswer == 1)
                {
                    compScore++;
                }
                if(compAnswer == 2)
                {
                    playerScore++;
                }
            }

            Play(playerScore, compScore);
        }
    }
}
