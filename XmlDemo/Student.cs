using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlDemo
{
    public class Student
    {
        private static int id = 1;
        public string Name { get; set; }
        [XmlAttribute(AttributeName ="studentIdentifier")]
        public int Id { get; set; }
        public int Age { get; set; }

        public Student()
        {
            this.Id = 1;
            this.Name = "No Name";
            this.Age = 0;
        }

        public Student(string name, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
            id++;
        }
    }
}
