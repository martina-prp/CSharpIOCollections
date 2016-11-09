using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDemo
{
    class Student
    {
        private static int id = 1;
        public string Name { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = Age;
            id++;
        }
    }
}
