using CsvHelper;
using FileIOLec.jsondataformat.JsonIODataFormat;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOLec.CsvFile.CsvDataOperation
{
    public class CsvDataOperation
    {
        public static void CsvSerialize()
        {
            Console.WriteLine("WELCOME");
            Student s = new Student();
            string csvFilePath= @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\CsvFile\CsvData.csv";
            List<Student> students = new List<Student>()
            {
                new Student() { FName = "Swagata", LName = "Sawant", Address = "Benglore", ZipCode = 768789 },
                new Student() { FName = "Shweta", LName = "Sapkal", Address = "Satara", ZipCode = 453216 }
            };
            StreamWriter sw = new StreamWriter(csvFilePath);
            // FileStream stream=
            CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture);
            cw.WriteRecords<Student>(students);
            //sw.Flush();
            sw.Close();
            Console.WriteLine("Closed");
        }
        public static void CsvDeserialize()
        {
            Student s = new Student() { FName="Snehal",LName="Jagtap",Address="Pali",ZipCode=453267};
            string csvFilePath= @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\CsvFile\CsvData.csv";
            List<Student> students = new List<Student>()
            {
                new Student() { FName = "Swagata", LName = "Sawant", Address = "Benglore", ZipCode = 768789 },
                new Student() { FName = "Shweta", LName = "Sapkal", Address = "Satara", ZipCode = 453216 },
                new Student(){ FName ="Pooja",LName="Kamire",Address ="Sangli",ZipCode =654321}
            };
            StreamReader swReader=new StreamReader(csvFilePath);
            CsvReader csvReader=new CsvReader(swReader, CultureInfo.InvariantCulture);
           // csvReader.GetRecords<List<Student>>();
           List<Student> students1 = csvReader.GetRecords<Student>().ToList();
            foreach(Student student in students1)
            {
                Console.WriteLine(student);
            }
            //swReader.Close();
        }
    }
}
