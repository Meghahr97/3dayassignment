using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace qstn3ofxml
{
    class readxml
    {
        List<information> plist = new List<information>();
        public readxml()
        {
            plist.Add(new information { Item = "keyboard", Manufacturer = "moto", Model = "old", Cost = 3500 });
            plist.Add(new information { Item = "mouse", Manufacturer = "iphone", Model = "new", Cost = 550 });
            plist.Add(new information { Item = "joystick", Manufacturer = "samsung", Model = "moderate", Cost = 700 });
        }

        public void writeXml()
        {
            XmlWriter w = XmlWriter.Create("c:\\Files\\information.xml");
            w.WriteStartDocument();
            w.WriteStartElement("information");
            foreach (var b in plist)
            {
                w.WriteStartElement("info");
                w.WriteElementString("Item", b.Item);
                w.WriteElementString("manufacturer", b.Manufacturer);
                w.WriteElementString("model", b.Model);
                w.WriteElementString("cost", b.Cost.ToString());
            }
            w.WriteEndElement();
            w.WriteEndDocument();
            w.Close();
            Console.WriteLine("xml created");
        }
        public void readml()
        {
            XElement xe = XElement.Load("c:\\Files\\information.xml");
            var data = xe.Elements();
            foreach(var d in data)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("*********");

            var data2 = from t in xe.Elements("part")
                        where (int)t.Element("cost") > 150
                        select t;
            foreach (var d in data2)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine("**********");
            foreach(var d in data)
            {
                Console.WriteLine(d.Element("Item").Value + " " + d.Element("cost").Value);
            }

        }
    }
}
