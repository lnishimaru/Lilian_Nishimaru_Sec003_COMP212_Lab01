using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lilian_Nishimaru_Sec003_COMP212_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            //func delegate to get the smallest of 3 strings using lambda expression  
            Func<string, string, string, string> testFunc2 = delegate (string value1, string value2, string value3)
            {
                if (String.Compare(value1, value2, StringComparison.Ordinal) <= 0 &&
                String.Compare(value1, value3, StringComparison.Ordinal) <= 0) //value1 is the smallest
                {
                     return value1;
                }
                else
                {
                    if (String.Compare(value2, value1, StringComparison.Ordinal) <= 0 &&
                        String.Compare(value2, value3, StringComparison.Ordinal) <= 0) //value2 is the smallest
                    {
                        return value2;
                    }
                    else
                    {
                        if (String.Compare(value3, value1, StringComparison.Ordinal) <= 0 &&
                            String.Compare(value3, value2, StringComparison.Ordinal) <= 0) //value3 is the smallest
                        {
                            return value3;
                        }
                        else //values are equal
                        {
                            return value1;
                        }
                    }

                }
            };
            string lesser = testFunc2("Lion", "Elephant", "Zebra");
            Console.WriteLine($"The smallest value is {lesser}");
            
            // action delegate to get the grades average
            Action<double, double, double> testAction = AvgGrade;
            testAction(7.5, 8, 9.5);

        } // end main

        //Method to calculate the average of 3 grades 
        private static void AvgGrade(double grade1, double grade2, double grade3)
        {
            Console.WriteLine($"Average is {(grade1 + grade2 + grade3) / 3:F2}");
        }
    } // end class
} // end namespace
