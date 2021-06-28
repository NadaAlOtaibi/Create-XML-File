using System;
using System.Xml;

namespace Student
{
    class XML
    {
        static void CreateXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            XmlElement root = xmldoc.CreateElement("Email");
            xmldoc.AppendChild(root);
            XmlElement element1 = xmldoc.CreateElement("from");
            XmlText text1 = xmldoc.CreateTextNode("Nada");
            root.AppendChild(element1);
            element1.AppendChild(text1);

            XmlElement element2 = xmldoc.CreateElement("to");
            XmlText text2 = xmldoc.CreateTextNode("Lana");
            root.AppendChild(element2);
            element2.AppendChild(text2);

            XmlElement element3 = xmldoc.CreateElement("message");
            XmlText text3 = xmldoc.CreateTextNode("Welcome to c#");
            root.AppendChild(element3);
            element3.AppendChild(text3);

            xmldoc.Save(@"/Users/nadaalotaibi/Downloads/Decomnt/email.xml");
            Console.WriteLine(xmldoc.InnerXml);


        }

        static void ReadXMLFile()
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(@"/Users/nadaalotaibi/Downloads/Decomnt/email.xml");
            foreach (XmlNode node in xmldoc.DocumentElement.ChildNodes)
            {
                string element = node.Name;
                Console.Write(element + ": ");

                string text = node.InnerText;
                Console.WriteLine(text);

            }
        }

        static void Main(string[] args)
        {
            CreateXMLFile();
            ReadXMLFile();

        }
            
        }
    }

