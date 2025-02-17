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
        public string Name;
        public int Age;
        public Student(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
    }
}
