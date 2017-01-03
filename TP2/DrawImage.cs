using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    class DrawImage : Panel
    {
        private int X = 0;
        private int Y = 0;
        private int lastX = 0;
        private int lastY = 0;
        private List<Photo> photos;
        private int selectedPhotoIndex = 0;
        private bool isSelected = false;
        private bool mouseIsDown = false;
        private Photo imgSelected = null;

        private int nbImages = 0;
        private Point oldPoint;

        public DrawImage()
        {
            this.Paint += drawImage_paint;
            this.MouseUp += mouseUp;
            this.MouseMove += mouseMove;
            this.MouseDown += mouseDown;
            this.DoubleBuffered = true;
            this.photos = new List<Photo>();
        }

        public void displayImage(String pic)
        {
            Bitmap image = new Bitmap(pic);
            Rectangle coord = new Rectangle();
            coord.X = lastX;
            coord.Y = lastY;
            coord.Height = ((Bitmap)image).Height;
            coord.Width = ((Bitmap)image).Width;
            Photo photo = new Photo(image, coord, nbImages);
            nbImages += 1;
            photos.Add(photo);
        }

        public void displayImage(Bitmap image)
        {
            Rectangle coord = new Rectangle();
            coord.X = lastX;
            coord.Y = lastY;
            coord.Height = (image).Height;
            coord.Width = (image).Width;
            Photo photo = new Photo(image, coord, nbImages);
            nbImages += 1;
            photos.Add(photo);
        }


        public void drawImage_paint(object sender, PaintEventArgs e)
        {
            if (this.photos.Count > 0)
            {
                int min = 0;
                foreach (Photo img in photos)
                {
                    if (img.Index < min) min = img.Index;
                }
                for (int i = min; i < photos.Count; i++)
                {

                    if (photos[i] != null)
                    {
                        Photo photoToDisplay = getPhotoByIndex(i);

                        e.Graphics.DrawImage(photoToDisplay.Image, photoToDisplay.X, photoToDisplay.Y);
                        X = Y += 10;
                        lastX = X;
                        lastY = Y;
                    }
                }
                X = Y = 0;

                if (isSelected)
                {
                    Pen pen = new Pen(Color.Red, 4);
                    e.Graphics.DrawRectangle(pen, photos[selectedPhotoIndex].Rect);
                }
            }
        }

        private void mouseDown(Object sender, MouseEventArgs e) 
        { 
            mouseClick(sender, e);
        }

        private void mouseClick(Object sender, MouseEventArgs e)
        {
            mouseIsDown = true;
            for (int i = photos.Count - 1; i >= 0; i--)
            {
                if (getPhotoByIndex(i) != null)
                {
                    if (photos[i].contains(e.Location))
                    {
                        isSelected = true;
                        imgSelected = getPhotoByIndex(i);
                        selectedPhotoIndex = i;
                        oldPoint = e.Location;
                        this.Invalidate();
                        break;
                    }
                    else
                    {
                        imgSelected = null;
                        isSelected = false;
                    }
                }
            }
            this.Invalidate();
        }

        private void mouseMove(Object sender, MouseEventArgs e)
        {
            if (isSelected && mouseIsDown)
            {
                imgSelected.X = imgSelected.X + e.X - oldPoint.X;
                imgSelected.Y = imgSelected.Y + e.Y - oldPoint.Y;
                oldPoint = e.Location;
                this.Invalidate();
            } 
        }

        private void mouseUp(Object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }


        public void imgUp()
        {
            int val1 = imgSelected.Index;
            if (val1 < nbImages-1) {
                int val2 = getPhotoByIndex(imgSelected.Index + 1).Index;
                int valTemp = getPhotoByIndex(imgSelected.Index + 1).Index;
                getPhotoByIndex(imgSelected.Index + 1).Index = val1;
                imgSelected.Index = val2;
            }
         
            this.Invalidate();
        }

        public void imgDown()
        {
            int val1 = imgSelected.Index;
            if (val1 > 0)
            {
                int val2 = getPhotoByIndex(imgSelected.Index - 1).Index;
                int valTemp = getPhotoByIndex(imgSelected.Index - 1).Index;
                getPhotoByIndex(imgSelected.Index - 1).Index = val1;
                imgSelected.Index = val2;
            }
            this.Invalidate();
        }

        private Photo getPhotoByIndex(int index)
        {
            Photo theGoodOne=null;
            foreach(Photo photo in photos)
            {
                if (photo.Index == index) theGoodOne = photo;
            }
            return theGoodOne;
        }

        public void suppr()
        {
            int temp = selectedPhotoIndex;
            photos.Remove(imgSelected);
            nbImages -= 1;
            foreach (Photo photo in photos)
            {
                if(photo.Index > temp)
                {
                    photo.Index -= 1;
                }
            }
            selectedPhotoIndex = 0;
            imgSelected = getPhotoByIndex(0);
            this.Invalidate();
        }

        public void copy()
        {
            Clipboard.SetImage(imgSelected.Image);
        }

        public void cut()
        {
            copy();
            suppr();
        }

        public void paste()
        {
            Bitmap image = (Bitmap)Clipboard.GetImage();
            displayImage(image);
            this.Invalidate();
        }

    }
}
