using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewProject;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //default case
            int n = 50;
            List<Condition> conditions = new List<Condition>();
            conditions.Add(new Condition(3, "Fizz"));
            conditions.Add(new Condition(5, "Buzz"));
            List<string> listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, n);

            foreach(string s in listOfText)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
