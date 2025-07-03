
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge2
{
    abstract class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public double Grade { get; set; }

        public Student(string name, int studentId, double grade)
        {
            Name = name;
            StudentId = studentId;
            Grade = grade;
        }

        public abstract bool IsPassed(double grade);
    }

    class Undergraduate : Student
    {
        public Undergraduate(string name, int studentId, double grade) : base(name, studentId, grade) { }

        public override bool IsPassed(double grade)
        {
            return grade > 70.0;
        }
    }

    class Graduate : Student
    {
        public Graduate(string name, int studentId, double grade) : base(name, studentId, grade) { }

        public override bool IsPassed(double grade)
        {
            return grade > 80.0;
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Undergraduate ugStudent = new Undergraduate("Rakesh", 1, 75.0);
            Graduate gradStudent = new Graduate("Naresh", 2, 85.0);

            Console.WriteLine($"{ugStudent.Name} has {(ugStudent.IsPassed(ugStudent.Grade) ? "passed" : "not passed")} the course.");
            Console.WriteLine($"{gradStudent.Name} has {(gradStudent.IsPassed(gradStudent.Grade) ? "passed" : "not passed")} the course.");

            Console.ReadLine();
        }
    }
}
