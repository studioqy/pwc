using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Allows user to input grade percentage
            Console.Write("What is your grade percentage in this course? ");
            string strGradePercentage = Console.ReadLine();

            //Converts input to an int
            int gradePercentage = int.Parse(strGradePercentage);
            string letter;

            //Calculates latter grade based on grade percentage
            if (gradePercentage >= 90)
            {
                letter = "A";
            }
            else if (gradePercentage >= 80)
            {
                letter = "B";
            }
            else if (gradePercentage >= 70)
            {
                letter = "C";
            }
            else if (gradePercentage >= 60)
                {
                letter = "D";
                }
            else
            {
                letter = "F";
            }

            //Prints whether the user passed or failed based on their grade
            //percentage
            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congrats! You passed the course!");
            }
            else
            {
                Console.WriteLine("Oh no! You failed this course!");
            }

            //Prints the user's letter grade
            Console.WriteLine($"Your final letter grade was {letter} for this course.");
        }
    }
}
