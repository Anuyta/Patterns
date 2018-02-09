using System.Collections.Generic;
using System.Drawing;

namespace Task3
{
    class ElementFactory
    {
        private readonly Dictionary<Color, Element> lines = new Dictionary<Color, Element>();        

        public Element GetCharacter(Color color)
        {
            if (!lines.ContainsKey(color))
            {
                if (color == Color.Black)
                {
                    lines.Add(color, new BlackLine());
                }
                else
                {
                    lines.Add(color, new ColorLine(color));
                }
            }
            return lines[color];
        }
    }
}
