using System.Drawing;

namespace Task4
{
    interface INegative
    {
        Bitmap GetNegativeImage();

        Bitmap TurnRight();

        Bitmap TurnLeft();
    }
}
