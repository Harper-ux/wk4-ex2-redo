using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk4_ex2_rework
{
    internal class Program
    {
        static double assignments()
        {
            Console.WriteLine("Please enter your assignment grade: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static double midterm()
        {
            Console.WriteLine("Please enter your midterm grade: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static double finalExam()
        {
            Console.WriteLine("Please enter your Final Exam grade: ");
            return Convert.ToDouble(Console.ReadLine());
        }
        static void CalculateGrade(double assignment, double midterm, double finalExam)
        {
            double finalGrade = (assignment * 0.4) + (midterm * 0.2) + (finalExam * 0.4);
            Console.WriteLine($"Your final grade is: {finalGrade}");
        }

        static void Main(string[] args)
        {
            double assignmentGrade = assignments();
            double midtermGrade = midterm();
            double finalExamGrade = finalExam();
            CalculateGrade(assignmentGrade, midtermGrade, finalExamGrade);
        }
    }
}
