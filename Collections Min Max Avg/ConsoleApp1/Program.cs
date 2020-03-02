using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_2
{
    class Program
    {
        static void Main(string[] args)
        {//Shaun Poweshiek, worked with Robert Young, Author Kudhlamde, Cale

        //Part 1
        //string[] classes = { "MIS", "MATH", "MGT", "FIN" };
        //string[] courseNum = { "3013", "3033", "3013", "2303" };

        string[] classes = new string[3];
        string[] courseNum = new string[3];

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("Please enter your course name:");
                classes[i] = Console.ReadLine();
            }
            for (int i = 0; i < courseNum.Length; i++)
            {
                Console.WriteLine("Please enter your course number:");
                courseNum[i] = Console.ReadLine();
            }

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine(string.Concat(classes[i].ToUpper(), courseNum[i].ToUpper()));
            }

            //Part 2
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


            Console.ReadKey();
        }
    }
}
