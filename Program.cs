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
            else if (playerScore == 3)
            {
                Console.WriteLine("You Win!");
            }
            else if (compScore == 3)
            {
                Console.WriteLine("You Lose :(");
            }
        }

        static int Number() {
            Random r = new Random();
            int genRand= r.Next(1,4);
            return genRand;
        }

        static void Compare(int playerAnswer, int compAnswer, int playerScore, int compScore)
        {
            if(playerAnswer == 1)
            {
                if(compAnswer == 1)
                {
                    Console.WriteLine("Computer: Rock!");
                }
                if(compAnswer == 2)
                {
                    Console.WriteLine("Computer: Paper!");
                    compScore++;
                }
                if(compAnswer == 3)
                {
                    Console.WriteLine("Computer: Scissors!");
                    playerScore++;
                }
            }

            if(playerAnswer == 2)
            {
                if(compAnswer == 2)
                {
                    Console.WriteLine("Computer: Paper!");
                }
                if(compAnswer == 3)
                {
                    Console.WriteLine("Computer: Scissors!");
                    compScore++;
                }
                if(compAnswer == 1)
                {
                    Console.WriteLine("Computer: Rock!");
                    playerScore++;
                }
            }

            if(playerAnswer == 3)
            {
                if(compAnswer == 3)
                {
                    Console.WriteLine("Computer: Scissors!");
                }
                if(compAnswer == 1)
                {
                    Console.WriteLine("Computer: Rock!");
                    compScore++;
                }
                if(compAnswer == 2)
                {
                    Console.WriteLine("Computer: Paper!");
                    playerScore++;
                }
            }

            Play(playerScore, compScore);
        }
    }
}
