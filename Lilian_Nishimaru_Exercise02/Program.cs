using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilian_Nishimaru_Exercise02
{
    //delegate to produce a bool and receive a double if the parameter matches the lambda expression criteria
    public delegate bool GradesPredicate(double grade);
    class Program
    {
        static void Main(string[] args)
        {
            double[] grades = new double[] { 10.5,100,20,55,80.2,95.8,34.7,89.0,67.5,90} ;
            //call the method to filter grades greater or equal 50
            GradesFilter(grades, x => (x >= 50));
        }
        //Method to filter the grades array with a lambda expression passed 
        //input is grades array and  predicate (lambda expression) 
        static void GradesFilter(double [] numbers, GradesPredicate test)
        {
            Console.WriteLine("Grades above or equal 50:");
            foreach (double number in numbers)
            {
                if (test(number))
                {
                    Console.WriteLine($"{number}");
                }
            }
        }
    }
}
