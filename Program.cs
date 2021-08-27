using System;
using static System.Console;
namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int TestScore1, TestScore2, TestScore3, TestScore4, TestScore5;
            double average;

            WriteLine("Please enter your score for TEST 1");
            TestScore1 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter your score for TEST 2");
            TestScore2 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter your score for TEST 3");
            TestScore3 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter your score for TEST 4");
            TestScore4 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter you sccore for TEST 5");
            TestScore5 = Convert.ToInt32(ReadLine());

            average = Convert.ToDouble (TestScore1 + TestScore2 + TestScore3 + TestScore4 + TestScore5) / 5;
            
          
            WriteLine("YOUR AVERAGE SCORE IS {0}", average.ToString("F2"));
        } 
    }
}
