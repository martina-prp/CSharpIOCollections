using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XmlDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StudentFactory factory = new StudentFactory();
            List<Student> students = factory.Create(input);

            XmlDocument document = new XmlDocument();
            XmlNode root = document.CreateElement("students");
            document.AppendChild(root);
            foreach(var item in students)
            {
                XmlElement student = document.CreateElement("student");
                root.AppendChild(student);
                XmlAttribute attr = document.CreateAttribute("id");
                attr.Value = item.Id.ToString();
                student.SetAttributeNode(attr);

                XmlElement studentName = document.CreateElement("name");
                student.AppendChild(studentName);
                studentName.InnerText = item.Name;

                XmlElement studentAge = document.CreateElement("age");
                student.AppendChild(studentAge);
                studentAge.InnerXml = item.Age.ToString();
            }

            document.Save("../../students.xml");


            // Second way of serialization to xml
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));

            using (XmlWriter writer = XmlWriter.Create("../../students2.xml"))
            {
                xmlSerializer.Serialize(writer, students);
            }
        }
    }
}
