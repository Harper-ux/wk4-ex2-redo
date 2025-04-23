using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk4_ex2_rework
{
    internal class Program
    {
        static double assignments() //creates a method for the assignment portion
        {
            Console.WriteLine("Please enter your assignment grade: "); //prompts the user for their assignment grade
            return Convert.ToDouble(Console.ReadLine()); //reads the input and converts it to a double
        }
        static double midterm() //creates a method for the midterm test grades.
        {
            Console.WriteLine("Please enter your midterm grade: "); //prompts the user to input score
            return Convert.ToDouble(Console.ReadLine()); //reads the input and converts it to a double
        }
        static double finalExam() //creates a method for the final exam grades.
        {
            Console.WriteLine("Please enter your Final Exam grade: "); //prompts the user to input score
            return Convert.ToDouble(Console.ReadLine()); //reads the input and converts it to a double
        }
        static void CalculateGrade(double assignment, double midterm, double finalExam) //creates a method to calculate the final grade by mutiplying all the 3 together
        {
            double finalGrade = (assignment * 0.4) + (midterm * 0.2) + (finalExam * 0.4); //calculates the final grade by multiplying the assignment grade by 0.4, midterm by 0.2 and final exam by 0.4
            Console.WriteLine($"Your final grade is: {finalGrade}"); //displays the final grade to the user
        }

        static void Main(string[] args)
        {
            double assignmentGrade = assignments(); //calls the assignment method
            double midtermGrade = midterm(); //calls the midterm method
            double finalExamGrade = finalExam(); //calls the final exam method
            CalculateGrade(assignmentGrade, midtermGrade, finalExamGrade); //calls the final grade method
        }
    }
}
