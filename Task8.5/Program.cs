using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Task8._2;

namespace Task8._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MyClass myClass = new MyClass();

            using (StreamWriter file = File.CreateText(@"Serialization.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, myClass);
                Console.WriteLine("Серіалізація пройшла успішно");
            }

            Console.ReadLine();
        }
    }
}
