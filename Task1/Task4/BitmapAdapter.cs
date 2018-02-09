using AForge.Imaging.Filters;
using System.Drawing;

namespace Task4
{
    public class BitmapAdapter : INegative
    {
        private Bitmap image;

        public BitmapAdapter(Bitmap image)
        {
            this.Image = image;
        }

        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        public Bitmap GetNegativeImage()
        {
            Bitmap newImage = (Bitmap)image.Clone();
            Invert filter = new Invert();
            filter.ApplyInPlace(newImage);
            return newImage;
        }

        public Bitmap TurnRight()
        {
            Bitmap newImage = (Bitmap)image.Clone();
            newImage.RotateFlip(RotateFlipType.Rotate90FlipY);
            return newImage;
        }

        public Bitmap TurnLeft()
        {
            Bitmap newImage = (Bitmap)image.Clone();
            newImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            return newImage;
        }
    }
}
