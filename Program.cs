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
                RockPrint();
                Console.WriteLine("vs");
                if(compAnswer == 1)
                {
                    RockPrint();
                }
                if(compAnswer == 2)
                {
                    PaperPrint();
                    compScore++;
                }
                if(compAnswer == 3)
                {
                    ScissorsPrint();
                    playerScore++;
                }
            }

            if(playerAnswer == 2)
            {
                PaperPrint();
                Console.WriteLine("vs");
                if(compAnswer == 1)
                {
                    RockPrint();
                    playerScore++;
                }
                if(compAnswer == 2)
                {
                    PaperPrint();
                }
                if(compAnswer == 3)
                {
                    ScissorsPrint();
                    compScore++;
                }
            }

            if(playerAnswer == 3)
            {
                ScissorsPrint();
                Console.WriteLine("vs");
                if(compAnswer == 1)
                {
                    RockPrint();
                    compScore++;
                }
                if(compAnswer == 2)
                {
                    PaperPrint();
                    playerScore++;
                }
                if(compAnswer == 3)
                {
                    ScissorsPrint();
                }
            }

            Play(playerScore, compScore);
        }

        static void RockPrint()
        {
            Console.WriteLine(@"
                    _______
                ---'   ____)
                        (_____)
                        (_____)
                        (____)
                ---.__(___)            
            ");
        }

        static void PaperPrint()
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

        static void ScissorsPrint()
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
