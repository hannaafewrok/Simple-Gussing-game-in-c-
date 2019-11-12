using System;

namespace gueesinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hanna's gussing game. Try to guess what I have in mind**");
           
            String guess = "";
            String correctWord = "hanna";
            int guessctrl = 0;
            int guesslimit = 3;
            bool outofguess = false;

            
            while (guess != correctWord && !outofguess)
            {
                if (guessctrl < guesslimit)
                {
                    Console.WriteLine("Enter Your Guess: ");
                    guess = Console.ReadLine();
                    guessctrl++;


                }
                else
                {
                    outofguess = true;

                }
            }
                if (outofguess)
                {
                    Console.WriteLine("OOPS, You Lost. ");
                }
                else
                {
                    Console.WriteLine("COngratulations, You've guessed right.");
                }
            Console.ReadKey();
                }
            
        }
    }


