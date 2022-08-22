using System;

namespace PinCodeGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            String crctPin = "7842";              //input the correct pin (has to be < 10000)
            String guess = "";

            int guessnum;                         //number guessed
            int numOfGuess = 0;                       //how many tries

            Random random = new Random();

            Console.WriteLine("Hello This is a Pin Guesser!");
            Console.WriteLine("Your pin is " + crctPin);

            while(guess != crctPin)
            {
                guessnum = random.Next(0, 10000);//gives us a random pin
                if(guessnum < 10)               //guess num is single digit
                {
                    guess = "000" + guessnum;
                }
                else if(guessnum < 100)         //guess num is double digit
                {
                    guess = "00" + guessnum;
                }       
                else if(guessnum < 1000)        //guess num is triple digit
                {
                    guess = "0" + guessnum;
                }
                else                            //guess num is a full pin
                {
                    guess = guessnum.ToString();    
                }
                Console.WriteLine("Current pin guess is " + guess);
                numOfGuess += 1;
            }
            Console.Clear();
            Console.WriteLine("Your pin is " + crctPin);
            Console.WriteLine("Pin guessed is " + guess);
            Console.WriteLine("Your pin was guess in " + numOfGuess + " tries");
        }
    }
}
