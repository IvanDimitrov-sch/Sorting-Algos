using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string Name {get;set;}
        public int Age {get;set;}
        public double Grade { get; set; }
        public Student(string name, int age = 0, double grade = 0)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        
    }
}
