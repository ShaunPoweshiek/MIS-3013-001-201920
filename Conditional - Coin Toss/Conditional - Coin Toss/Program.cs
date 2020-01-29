//Shaun Poweshiek
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional___Coin_Toss
{
    class Program
    {
        const string Message = "Developer is Shaun Poweshiek";
        static void Main(string[] args)
        {
            
            Console.Write("Enter Heads or Tails >>");
            string userGuessAsString = Console.ReadLine();
            int userGuess;

            if (userGuessAsString == "Heads")
            {
                userGuess = 0;
            }
            else
            {
                userGuess = 1;
            }

            if (userGuessAsString == "Tails")
            {
                userGuess = 0;
            }
            else
            {
                userGuess = 1;
            }
            Random rand = new Random();
            //use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1
            int randomNumber = rand.Next(0,2);

            Console.ReadKey(); //Prevents the application from closing until we press a key
        }
    }
}
