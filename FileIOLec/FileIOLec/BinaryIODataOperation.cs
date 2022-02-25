using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOLec
{
    public class BinaryIODataOperation
    {
        public static void BinarySerialize()
        {
            string binaryFilePath = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\files\binaryData.bin";
            Contact contact = new Contact(){ FName="Shweta",LName="sapkal",Address="Satara",ZipCode=56102};
            
            FileStream stream = new FileStream(binaryFilePath,FileMode.OpenOrCreate);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(stream, contact);
        }

        public static void BinaryDeserialize()
        {
            string binaryFilePath = @"C:\Users\user\Fellowship\fileIOLec\FileIOLec\FileIOLec\files\binaryData.bin";
            Contact contact = new Contact() { FName = "Shweta", LName = "sapkal", Address = "Satara", ZipCode = 56102 };

            FileStream stream = new FileStream(binaryFilePath, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            Contact contact1=(Contact) binary.Deserialize(stream);
            Console.WriteLine(contact1);
        }
    }
    [Serializable]
    class Contact
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
