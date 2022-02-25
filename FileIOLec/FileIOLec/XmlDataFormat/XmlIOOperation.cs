using FileIOLec.jsondataformat.JsonIODataFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOLec.XmlDataFormat
{
    public class XmlIOOperation
    {
        public static void XmlSerialize()
        {
            string xmlFilePath = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\files\xmlData.xml";
            List<Student> students = new List<Student>()
            {
                new Student(){FName="Swagata",LName="Sawant",Address="Benglore",ZipCode=768789}
            };
            FileStream stream = new FileStream(xmlFilePath, FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Student));
        foreach(Student student in students)
            {
                xml.Serialize(stream, student);
            }
        }

        public static void XmlDeserialize()
        {
            string xmlFilePath = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\files\xmlData.xml";
            //List<Student> students = new List<Student>()
            //{
             //   new Student(){FName="Swagata",LName="Sawant",Address="Benglore",ZipCode=768789}
            //};
            FileStream stream = new FileStream(xmlFilePath, FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Student));
           Student res=(Student)xml.Deserialize(stream);
            Console.WriteLine(res);
        }
    }
}
