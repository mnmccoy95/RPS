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
                ---------------------------"
            );

            if(playerScore != 3 && compScore != 3)
            {
                Console.Write($@"
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

                Console.WriteLine(@"
                    You win!"
                );
            }
            else if (compScore == 3)
            {
                Console.WriteLine(@"
                    You lose :("
                );
            }
        }
        static int Number() {
            Random r = new Random();
            int genRand= r.Next(1,4);
            return genRand;
        }
        static void Compare(int playerAnswer, int compAnswer, int playerScore, int compScore)
        {
            PrintASCII(playerAnswer);
            Console.WriteLine(@"
                vs."
            );
            PrintASCII(compAnswer);

            if(compAnswer == playerAnswer + 1 | compAnswer == playerAnswer - 2)
            {
                compScore++;
            }
            else if(playerAnswer == compAnswer + 1 | playerAnswer == compAnswer - 2)
            {
                playerScore++;
            }

            Play(playerScore, compScore);
        }

        static void PrintASCII(int hand)
        {
            if(hand == 1){
            Console.WriteLine(@"
                    _______
                ---'   ____)
                        (_____)
                        (_____)
                        (____)
                ---.__(___)            
            ");
            }

            if(hand == 2)
            {
                Console.WriteLine(@"
                    _______
                ---'    ____)____
                            ______)
                            _______)
                            _______)
                ---.__________)            
            ");
            }

            if(hand == 3)
            {
                Console.WriteLine(@"
                    _______
                ---'   ____)____
                            ______)
                        __________)
                        (____)
                ---.__(___)            
                ");
            }
        }
    }
}
