using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlDemo
{
    class StudentFactory
    {
        public List<Student> Create(string[] names)
        {
            List<Student> students = new List<Student>();
            foreach(var item in names)
            {
                students.Add(new Student(item, 25));
            }
            return students;
        }
    }
}
