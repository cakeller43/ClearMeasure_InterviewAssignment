using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InterviewProject;


namespace UnitTestingInterview.Test
{
   [TestFixture]
    public class PrintNumbersTest
    {
       List<Condition> conditions = new List<Condition>();
       List<string> answerText = new List<string>();
       int upperBound = 0;
       List<string> listOfText;

       private void ResetParameters()
       {
           answerText.Clear();
           conditions.Clear();
           upperBound = 0;
           
       }

       [Test]
       public void PrintNumbers_Default()
       {
           ResetParameters();

           upperBound = 10;
           
           answerText.Add("1");
           answerText.Add("2");
           answerText.Add("Fizz");
           answerText.Add("4");
           answerText.Add("Buzz");
           answerText.Add("Fizz");
           answerText.Add("7");
           answerText.Add("8");
           answerText.Add("Fizz");
           answerText.Add("Buzz");
                     
           conditions.Add(new Condition(3, "Fizz"));
           conditions.Add(new Condition(5, "Buzz"));
           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           Assert.AreEqual(listOfText.Count, upperBound);
           for (int i = 0; i < answerText.Count; i++ )
               Assert.AreEqual(answerText[i], listOfText[i]);

       }
       [Test]
       public void PrintNumbers_Condition1()
       {
           ResetParameters();

           upperBound = 10;

           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");
           answerText.Add("Condition");


           conditions.Add(new Condition(1, "Condition"));

           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           Assert.AreEqual(listOfText.Count, upperBound);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i], listOfText[i]);

       }       
      
       [Test]
       public void PrintNumbers_Upper15()
       {
           ResetParameters();

           upperBound = 15;

           answerText.Add("1");
           answerText.Add("2");
           answerText.Add("Fizz");
           answerText.Add("4");
           answerText.Add("Buzz");
           answerText.Add("Fizz");
           answerText.Add("7");
           answerText.Add("8");
           answerText.Add("Fizz");
           answerText.Add("Buzz");
           answerText.Add("11");
           answerText.Add("Fizz");
           answerText.Add("13");
           answerText.Add("14");
           answerText.Add("FizzBuzz");

         
           conditions.Add(new Condition(3, "Fizz"));
           conditions.Add(new Condition(5, "Buzz"));
           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           Assert.AreEqual(listOfText.Count, upperBound);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i],listOfText[i]);
       }

       [Test]
       public void PrintNumbers_ZeroForUpper()
       {
           ResetParameters();

           upperBound = 0;
           answerText.Add("You must enter a non-zero positive number as upperBound.");
           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i],listOfText[i]);
       }

       [Test]
       public void PrintNumbers_NegativeForUpper()
       {
           ResetParameters();

           upperBound = -50;
           answerText.Add("You must enter a non-zero positive number as upperBound.");
           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i], listOfText[i]);
       }

       [Test]
       public void PrintNumbers_EmptyConditionsPositiveUpper()
       {
           ResetParameters();

           upperBound = 10;

           answerText.Add("1");
           answerText.Add("2");
           answerText.Add("3");
           answerText.Add("4");
           answerText.Add("5");
           answerText.Add("6");
           answerText.Add("7");
           answerText.Add("8");
           answerText.Add("9");
           answerText.Add("10");

           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i], listOfText[i]);
       }

       [Test]
       public void PrintNumbers_MaxIntUpper()
       {
           ResetParameters();

           upperBound = int.MaxValue;

           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);
           Assert.NotNull(listOfText);
           Assert.AreEqual("OutOfMemoryException has occured. Try using a smaller upperBound.", listOfText[0]);
       }

       [Test]
       public void PrintNumbers_NullConditions()
       {
           ResetParameters();

           upperBound = 10;

           answerText.Add("1");
           answerText.Add("2");
           answerText.Add("3");
           answerText.Add("4");
           answerText.Add("5");
           answerText.Add("6");
           answerText.Add("7");
           answerText.Add("8");
           answerText.Add("9");
           answerText.Add("10");

           listOfText = InterviewProject.PrintNumbers.printNumbers(null, upperBound);

           Assert.NotNull(listOfText);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i], listOfText[i]);
       }

       [Test]
       public void PrintNumbers_LongCondition()
       {
           ResetParameters();

           upperBound = 10;

           answerText.Add("1");
           answerText.Add("2");
           answerText.Add("3");
           answerText.Add("4");
           answerText.Add("LooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooongCondition");
           answerText.Add("6");
           answerText.Add("7");
           answerText.Add("8");
           answerText.Add("9");
           answerText.Add("LooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooongCondition");


           conditions.Add(new Condition(5, "LooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooongCondition"));

           listOfText = InterviewProject.PrintNumbers.printNumbers(conditions, upperBound);

           Assert.NotNull(listOfText);
           Assert.AreEqual(listOfText.Count, upperBound);
           for (int i = 0; i < answerText.Count; i++)
               Assert.AreEqual(answerText[i], listOfText[i]);

       }

    }
}
