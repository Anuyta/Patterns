using System.Drawing;

namespace Task3
{
    class ColorLine : Element
    {
        private Color color;

        public ColorLine(Color color)
        {
            this.color = color;
        }
        public override void Drow(Graphics gr, Point p1, Point p2)
        {
            gr.DrawLine(new Pen(color, 5), p1, p2);
        }
    }
}
