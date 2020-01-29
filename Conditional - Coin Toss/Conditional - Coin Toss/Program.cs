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
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Heads or Tails >>");
            string usersGuess = Console.ReadLine();

            Random rand = new Random();
            //use the next method on 'rand' and pass in 0,2 to generate a random number that is 0 or 1
            int randomNumber = rand.Next(0, 2);
            string outcome = "";

            if (randomNumber==0)
            {
                outcome = "Heads";
            }
            else if (randomNumber==1)
            {
                outcome = "Tails";
            }

            if (usersGuess==outcome)
            {
                Console.WriteLine("You Won!");
            }

            else if (usersGuess!=outcome)
            {
                Console.WriteLine("You Lost!");
            }

            const string Name = "Dev: Shaun Poweshiek";
            Console.WriteLine(Name);
            Console.ReadKey(); //Prevents the application from closing until we press a key
        }
    }
}
