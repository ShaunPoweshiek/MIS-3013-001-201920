using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Min_Max_Avg
{
    class Program
    {
        static void Main(string[] args)
        {//Shaun Poweshiek, worked with Robert Young & Author Kudhlamde


            
            string examInput = "Y", answer;
            List<double> scores = new List<double>();

            do
            {
                
                Console.Write("Enter your test score?");
                examScore = Console.ReadLine();
                double es = Convert.ToDouble(examScore);
                scores.Add(es);
                //scores.Add(Convert.ToDouble(Console.ReadLine()));


                Console.WriteLine("Do you have another exam to add? (Y=Yes,N=No)");
                answer = Console.ReadLine();
            }
            while (answer.ToLower == "Y");


            double sum = 0; //this is often referred to as an ACCUMULATOR variable
            double minimum = scores[0];
            double maximum = scores[0];

            for (int i = 0; i < scores.Count; i++)
            {
                double score = scores[i];
                sum = sum + score;

                if (score < minimum)
                {
                    minimum = score;
                }
                if (score > maximum)
                {
                    maximum = score;
                }
            }

            foreach (var score in scores)
            {
                sum = sum + score;

                if (score < minimum)
                {
                    minimum = score;
                }
                if (score > maximum)
                {
                    maximum = score;
                }
            }


            double average = sum / scores.Count;

            Console.WriteLine($"Your average for the {scores.Count} exam grades is {average.ToString("N3")}");
            Console.WriteLine($"Your minimum exam grades is {minimum.ToString("N3")}");
            Console.WriteLine($"Your maximum exam grades is {maximum.ToString("N3")}");



            Console.ReadKey();

            


            /*int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);*/
        }
    }
}
