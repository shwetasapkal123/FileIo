using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOLec.jsondataformat.JsonIODataFormat
{
     public class JsonIODataFormat
    {
        public static void JsonSerialize()
        {
            string jsonFilePath = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\jsondataformat\JsonData.json";
            List<Student> student = new List<Student>()
            {
                new Student(){FName="Shweta",LName="Sapkal",Address="Satara",ZipCode=415004},
                new Student(){FName="Sneha",LName="Jagtap",Address="Pali",ZipCode=546687}
            };
           // FileStream stream=new FileStream(jsonFilePath,FileMode.OpenOrCreate);
            string res = JsonConvert.SerializeObject(student);
            File.WriteAllText(jsonFilePath, res);
        }
        
    }
    class Student
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public override string ToString()
        {
            return $"{FName} {LName} {Address}  {ZipCode}";
        }

    }
}
