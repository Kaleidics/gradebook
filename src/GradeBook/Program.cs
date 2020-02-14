using System;
using System.Collections.Generic;
using GradeBook;

namespace GradeBook
{
    }
    class Program
    {
        static void Main(string[] args)
        {
           

            var book = new Book();
            book.AddGrade(89.1);

            var grades = new List<double>() { 11.7, 15.3, 6.11 };
            grades.Add(56.1);
            
           
            var result = 0.0;
            foreach(double number in grades) {
                result += number;
            }

            result /= grades.Count;

        }
    }
}
