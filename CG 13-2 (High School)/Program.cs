using System;
using System.Collections.Generic;
using System.Linq;

namespace CG_13_2__High_School_
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //created list to keep all students of student class in
            List<Student> students = new List<Student>
            {
                new Student() {FirstName = "Kristen", LastName = "Shea", Grade = 11, GPA = 3.7},
                new Student() {FirstName = "Shannon", LastName = "Wrobleski", Grade = 7, GPA = 2.5},
                new Student() {FirstName = "Stan", LastName = "Schoeber", Grade = 4, GPA = 4.0},
                new Student() {FirstName = "David", LastName = "Hill", Grade = 2, GPA = 2.0},
                new Student() {FirstName = "Katie", LastName = "Reifsteck", Grade = 7, GPA = 3.4},
                new Student() {FirstName = "Karen", LastName = "Voss", Grade = 12, GPA = 1.0},
                new Student() {FirstName = "Bill", LastName = "Shea", Grade = 9, GPA = 3.5},
                new Student() {FirstName = "Emily", LastName = "Voss", Grade = 10, GPA = 3.0},
                new Student() {FirstName = "Tanya", LastName = "Falls", Grade = 9, GPA = 1.7},
                new Student() {FirstName = "Lindsay", LastName = "Webb", Grade = 3, GPA = 4.0},
                new Student() {FirstName = "Molli", LastName = "Benz", Grade = 8, GPA = 3.5},
                new Student() {FirstName = "William", LastName = "Smith", Grade = 11, GPA = 3.1}
            };

            //created list to keep all students with a GPA of 3.0 or greater and in grade 9 or higher
            //sorted students in list by grade first, then GPA, then last name, then first name
            var highGPA = students.Where(s => s.GPA >= 3 && s.Grade >= 9 ).
                OrderByDescending(s => s.Grade).OrderByDescending(s => s.GPA).OrderBy(s => s.LastName).
                OrderBy(s => s.FirstName).ToList();

            //printed student info from highGPA list to console, formatted for legibility
            foreach (var student in highGPA)
            {
                Console.WriteLine("Name: {0} {1} \n Grade: {2} \n GPA: {3}", 
                    student.FirstName, student.LastName, student.Grade, student.GPA);

                Console.WriteLine();
            }

            
            Console.ReadLine();

           

        }
    }
}
