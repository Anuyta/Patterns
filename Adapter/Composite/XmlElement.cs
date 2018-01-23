using System;

namespace Composite
{
    class XmlElement : Component
    {
        public string NameNode { get; set; }

        public string ValueNode { get; set; }

        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public override string Print()
        {
            return string.Format("     <{0}>{1}</{0}>\n", NameNode, ValueNode);
        }
    }
}
