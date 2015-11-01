using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewProject
{
    public class Condition
    {
        private int conditionNumber;
        private string conditionText;
        public Condition(int modNumber, string text)
        {
            conditionNumber = modNumber;
            conditionText = text;
        }

        public string CheckCondition(int currentBound )
        {
            return currentBound % conditionNumber == 0 ? conditionText : "";
        }
    }
}
