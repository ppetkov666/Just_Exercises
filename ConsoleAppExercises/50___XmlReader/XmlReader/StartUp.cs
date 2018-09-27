
namespace XmlReader
{
    using System;
    using System.Xml;
    class StartUp
    {
        static void Main(string[] args)
        {
            //XmlDocument xdocumnent = new XmlDocument();
            //Xdocumnent.Load(@"C:\Users\predator\Desktop\myxml.xml");
            //Xdocumnent.Save(Console.Out);

            //XmlDocument xdocumnent = new XmlDocument();
            //xdocumnent.Load(@"C:\Users\predator\Desktop\myxml.xml");
            ////Console.WriteLine(xdocumnent.OuterXml);
            //
            //XmlNode rootNode = xdocumnent.DocumentElement;
            //Console.WriteLine($"Root Node: {rootNode}");
            //
            //// rootNode.Attributes.Count = 0 
            //foreach (XmlAttribute atr in rootNode.Attributes)
            //{
            //    Console.WriteLine($"Attribute: {atr.Name}={atr.Value}");
            //}

            XmlTextReader xDocReader = new XmlTextReader(@"Enter the path to your XML file here");
            // in this case my xml file has info for student : name , age and score
            while (xDocReader.Read())
            {
                if (xDocReader.NodeType == XmlNodeType.Element && xDocReader.Name == "name")
                {
                    string str = xDocReader.ReadElementString();
                    Console.WriteLine($"My name is: {str}");
                }
                if (xDocReader.NodeType == XmlNodeType.Element && xDocReader.Name == "age")
                {
                    string str = xDocReader.ReadElementString();
                    Console.WriteLine($"I am {str} years old");
                }
                if (xDocReader.NodeType == XmlNodeType.Element && xDocReader.Name == "score")
                {
                    string str = xDocReader.ReadElementString();
                    Console.WriteLine($"My score in class is {str}");
                }
            }


        }
    }
}
