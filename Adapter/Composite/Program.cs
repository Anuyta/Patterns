using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xDoc = new XmlDocument() { NameNode = "node1" };
            XmlElement elem = new XmlElement() { NameNode = "subnode1", ValueNode = "111" };
            XmlElement elem2 = new XmlElement() { NameNode = "subnode2", ValueNode = "222" };
            xDoc.Add(elem);
            xDoc.Add(elem2);
            Console.WriteLine(xDoc.Print());

            Console.ReadLine();
        }
    }
}
