using System.Xml.Linq;

namespace Composite
{
    abstract class Component
    {
        protected string name;

        public string NameNode { get; set; }

        public string ValueNode { get; set; }

        public abstract void Add(Component component);

        public virtual XElement Create()
        {
            return new XElement(NameNode, ValueNode);
        }

        public abstract string Print();
    }
}
