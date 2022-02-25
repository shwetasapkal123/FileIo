using FileIOLec.CsvFile.CsvDataOperation;
using FileIOLec.jsondataformat.JsonIODataFormat;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOLec
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string path = "C:/Users/user/Fellowship/fileIOLec/FileIOLec/FileIOLec/sample.txt";
            //IsFileExists(path);
            // ReadLineByLine(path);
            //ReadOnce(path);
            //CopyFileContent(path);
            //string path = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\sampleCopyFile123.txt";
            //DeleteFile(path);
            //Console.WriteLine("Deleted");
            // ReadDataUsingStreamReader(path);
            // WriteDataUsingStreamReader(path);
            //BinaryIODataOperation.BinarySerialize();
            //BinaryIODataOperation.BinaryDeserialize();
            //JsonIODataFormat.JsonSerialize();
            //XmlDataFormat.XmlIOOperation.XmlSerialize();
            //XmlDataFormat.XmlIOOperation.XmlDeserialize();
            //CsvDataOperation.CsvSerialize();
            CsvDataOperation.CsvDeserialize();
            Console.ReadLine();
        }

        public static bool IsFileExists(string path)
        {
            if(File.Exists(path))
            {
                Console.WriteLine("File exists");
                return true;
            }
            else
            {
                Console.WriteLine("File not exists");
                return false;
            }
        }
        public static void ReadLineByLine(string path)
        {
            if(IsFileExists(path))
            {
                string[] lines=File.ReadAllLines(path);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public static void ReadOnce(string path)
        {
            if (IsFileExists(path))
            {
                string lines = File.ReadAllText(path);              
                    Console.WriteLine(lines);                
            }
        }

        public static void CopyFileContent(string path)
        {
            string destination = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\sampleCopyFile123.txt";
            if (IsFileExists(path))
            {
                File.Copy(path, destination);
            }
        }
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }

        public static void ReadDataUsingStreamReader(string path)
        {
            if(IsFileExists(path))
            {
                string line = " ";
                StreamReader str=File.OpenText(path);
                while((line =str.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                str.Close();
            }
        }
        public static void WriteDataUsingStreamReader(string path)
        {
            if (IsFileExists(path))
            {
              StreamWriter streamWriter=  File.AppendText(path);
                streamWriter.WriteLine("\n Writing");
                streamWriter.Close();

                ReadOnce(path);
            }
        }
    }
}
