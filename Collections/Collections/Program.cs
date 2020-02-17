using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of type int w/a size of 3
            int[] studentIds = new int[3];
            string[] studentNames = { "Adam", "Katie", "Micah" }; //these two arrays are parallel, values at the same INDEX coorelate to each other.

            //[0][1][2]
            studentIds[0] = 1;
            studentIds[1] = 2;
            studentIds[2] = 3;
            //INDEX OUT OF RANGE BECAUSE WE ONLY HAVE SPACE FOR 3 VALUES -- studentIds[3] = 4


            for (int i = 0; i < studentIds.Length; i++) //could also do studentNames.Length as they are PARALLEL
            {
                Console.WriteLine($"Student with ID {studentIds[i]} has a name of {studentNames[i]}");
            }

            // DO THE SAME THING BUT WITH LISTS

            List<int> studIds = new List<int>();
            studIds.Add(4);
            studIds.Add(5);
            studIds.Add(6);
            List<string> studNames = new List<string>(); // or you could add:  {"Lakin", "Grant", "Eric");
            studNames.Add("Lakin");
            studNames.Add("Grant");
            studNames.Add("Eric");

            for (int i = 0; i < studIds.Count; i++)
            {
                Console.WriteLine($"Student with ID {studIds[i]} has a name of {studNames[i]}");
            }

            //COMBINE ARRAY DATA AND LIST DATA INTO A DICTIONARY
            Dictionary<int, string> students = new Dictionary<int, string>();

            for (int i = 0; i < studentIds.Length; i++) //could also do studentNames.Length as they are PARALLEL
            {
                if (students.ContainsKey(studentIds[i]) == false)
                {
                    students.Add(studentIds[i], studentNames[i]);
                }
                if (students.ContainsKey(studentIds[i]) == false)
                {
                    students.Add(studentIds[i], studentNames[i]);
                }
            }
            Console.WriteLine("MADE IT THRU ALIVE");

            Console.WriteLine($"The dictionary has {students.Count()} students");

            Console.ReadKey();
        }
    }
}
