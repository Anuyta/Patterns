using System;
using System.Drawing;

namespace Flyweight
{
    class LatinCharacter : Character
    {
        public char Symbol { get; set; }

        public Bitmap Image { get; set; }

        public override void Drow(Graphics gr, int x, int y)
        {
            gr.DrawImage(Image, x, y);
        }
    }
}
