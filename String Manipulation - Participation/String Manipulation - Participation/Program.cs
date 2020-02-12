using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation___Participation
{
    class Program
    {
        static void Main(string[] args)
        {   // Shaun Poweshiek

            string message1 = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
            Console.WriteLine(message1);

            Console.WriteLine("What word do you want to look for in the above sentence?");
            string word1 = Console.ReadLine();

            bool message = message1.Contains(word1);
            Console.WriteLine(" '{0}' is in the string '{1}' : '{2}", word1, message1, message);

            Console.WriteLine("What word do you want to change it to?");
            string answer1 = Console.ReadLine();



            if (message1.Contains(word1))
            {
                Console.WriteLine($"Your word is...{word1}");

                Console.WriteLine("What word would you want to change?");
                string wordchange = Console.ReadLine();

                Console.WriteLine(message1.Replace(wordchange, word1));

            }
            else if (true)
            {
                Console.WriteLine($"Sorry, I could not find your word {word1}");
            }

            Console.ReadKey();


            //string errString = "This docment uses 3 other docments to docment the docmentation";

            //Console.WriteLine("The original string is:{0}'{1}'{0}", Environment.NewLine, errString);

            // Correct the spelling of "document".

            //string correctString = errString.Replace("docment", "document");

            //Console.WriteLine("After correcting the string, the result is:{0}'{1}'",
            //        Environment.NewLine, correctString);

            // This code example produces the following output:
            //
            // The original string is:
            // 'This docment uses 3 other docments to docment the docmentation'
            //
            // After correcting the string, the result is:
            // 'This document uses 3 other documents to document the documentation'
            //

        }
    }
}
