using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task8._2
{
    public class MyClass
    {
        private int id = 1;
        private string project = "ITVDN";
        private string country = "Ukraine";
        private string sphere = "IT";

        [XmlAttribute("MyId")]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        [XmlAttribute(AttributeName = "MyProject")]
        public string Project
        {
            get { return project; }
            set { project = value; }
        }

        [XmlAttribute("MyCountry")]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [XmlAttribute("MySphere")]
        public string Sphere
        {
            get { return sphere; }
            set { sphere = value; }
        }
    }
}
