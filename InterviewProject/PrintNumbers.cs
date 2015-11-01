using System;
using System.Collections.Generic;
using System.Linq;


namespace InterviewProject
{

    public static class PrintNumbers
    {
       
        public static List<string> printNumbers(List<Condition> conditions, int upperBound)
        {

            List<string> output = new List<string>();
            string toAdd = "";

            if(upperBound < 1)
            {
                output.Add("You must enter a non-zero positive number as upperBound.");
                return output;
            }

            if (conditions == null)
                conditions = new List<Condition>();

            try
            {
                for (int i = 1; i <= upperBound; i++)
                {
                    for (int k = 0; k < conditions.Count; k++)
                    {
                        toAdd += conditions[k].CheckCondition(i);
                    }

                    output.Add(toAdd == "" ? i.ToString() : toAdd);
                    toAdd = "";
                }
            }
            catch(OutOfMemoryException e)
            {
                output.Clear();
                output.Add("OutOfMemoryException has occured. Try using a smaller upperBound.");
                return output;
            }
            catch(Exception e)
            {
                output.Clear();
                output.Add("Exception has occured.");
                output.Add(e.ToString());
                return output;
            }
            

            return output;
        }

    }
}
