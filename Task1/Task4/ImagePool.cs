using System.Collections.Generic;
using System.Drawing;

namespace Task4
{
    public class ImagePool
    {
        private readonly int maxSize;
        private IList<Bitmap> images;
        private BitmapAdapter adapter;

        public IList<Bitmap> GetImages
        {
            get
            {
                return images;
            }

            set
            {
                images = value;
            }
        }

        public ImagePool(int maxSize)
        {
            this.maxSize = maxSize;
            GetImages = new List<Bitmap>();
        }

        public void CreateObjects(string fileName)
        {
            var adapter = new BitmapAdapter(new Bitmap(fileName));
            GetImages.Add(adapter.Image);
            GetImages.Add(adapter.GetNegativeImage());
            GetImages.Add(adapter.TurnRight());
            GetImages.Add(adapter.TurnLeft());     
        }
    }
}
