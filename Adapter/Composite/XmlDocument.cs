using System.Collections.Generic;
using System.Xml.Linq;

namespace Composite
{
    class XmlDocument : Component
    {
        private List<Component> children = new List<Component>();

        public string NameNode { get; set; }

        public string ValueNode { get; set; }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public virtual XElement Create()
        {
            var elements = new XElement(NameNode, ValueNode);
            foreach (var elem in children)
            {
                elements.Add(elem.Create());
            }
            return elements;
        }

        public override string Print()
        {
            string result = string.Format("<{0}>\n", NameNode);
            foreach (var elem in children)
            {
                result += elem.Print();
            }
            result += string.Format("</{0}>\n", NameNode);
            return result;
        }

        public void SaveDoc(string nameDoc)
        {
            Create().Save(nameDoc);
        }
    }
}
