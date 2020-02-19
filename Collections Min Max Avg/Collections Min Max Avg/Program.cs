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


            
            string examInput = "Y";
            

            do
            {
                
                Console.Write("Enter your test score?");
                double testScore = Convert.ToDouble(Console.ReadLine());
                


                Console.WriteLine("Do you have another exam to add? (Y=Yes,N=No)");
                string examInputAgain = Console.ReadLine();
            }
            while (examInput == "Y");


            List<double> testScore = new List<double>();


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
