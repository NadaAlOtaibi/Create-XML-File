using System;
using System.Xml;

namespace Student
{
    class Student
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
            XmlText text2 = xmldoc.CreateTextNode("Arwa");
            root.AppendChild(element2);
            element2.AppendChild(text2);

            XmlElement element3 = xmldoc.CreateElement("message");
            XmlText text3 = xmldoc.CreateTextNode("Welcome to c#");
            root.AppendChild(element3);
            element2.AppendChild(text3);

            xmldoc.Save(@"/Users/nadaalotaibi/Downloads/Decoemnt/email.xml");
            Console.WriteLine(xmldoc.InnerXml);


        }

        static void Main(string[] args)
        {
            CreateXMLFile();


        }
            
        }
    }

