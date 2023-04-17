using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Task8._2;

namespace Task8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(MyClass));
            MyClass myClass = new MyClass();
            using (FileStream stream = new FileStream("C:\\Users\\Dina_Nevhod\\source\\repos\\HW4.8\\Task8.2\\bin\\Debug\\Serialization.xml", FileMode.Open, FileAccess.Read,FileShare.Read))
            {
                Console.OutputEncoding = Encoding.UTF8;
                myClass = serializer.Deserialize(stream) as MyClass;
                Console.WriteLine("Десеріалізація пройшла успішно");
                Console.WriteLine("ID : " + myClass.Id + Environment.NewLine +
                                  "Project : " + myClass.Project + Environment.NewLine +
                                  "Country : " + myClass.Country + Environment.NewLine +
                                  "Sphere : " + myClass.Sphere + Environment.NewLine);
                Console.ReadLine();
            }
        }
    }
}
