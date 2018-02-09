using System.Drawing;

namespace Task3
{
    class BlackLine : Element
    {
        public override void Drow(Graphics gr, Point p1, Point p2)
        {
            gr.DrawLine(new Pen(Color.Black, 5), p1, p2);
        }
    }
}
