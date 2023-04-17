using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
            MyClass myClass = new MyClass();
            using (FileStream stream = new FileStream("Serialization.xml", FileMode.Create))
            {
                serializer.Serialize(stream,myClass);
                Console.WriteLine("Серіалізація пройшла успішно");
            }

            Console.ReadLine();
        }
    }
}
