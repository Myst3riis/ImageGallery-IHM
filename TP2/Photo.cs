using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Photo
    {
        private Bitmap image;
        private Rectangle rect;
        private int index;

        public Photo(Bitmap image, Rectangle rect, int index)
        {
            this.image = image;
            this.rect = rect;
            this.index = index;
        }

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public Rectangle Rect
        {
            get { return rect; }
        }

        public Bitmap Image
        {
            get { return image; }
        }

        public int X
        {
            get { return rect.X; }
            set { rect.X = value; }
        }

        public int Y
        {
            get { return rect.Y; }
            set { rect.Y = value; }
        }

        public int Height
        {
            get { return rect.Height; }
            set { rect.Height = value; }
        }

        public int Witdh
        {
            get { return rect.Width; }
            set { rect.Width = value; }
        }

        public bool contains(Point point)
        {
            return rect.Contains(point);
        }

        public String toString()
        {
            return "PHOTO : " + image + " XPOS : " + rect.X + " YPOS : " + rect.Y + " INDEX : " + index;
        }
    }
}
