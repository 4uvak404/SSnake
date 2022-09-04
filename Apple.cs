using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSnake
{
    internal class Apple
    {
        private int mapWidth;
        private int mapHeight;
        private Bitmap? picture;
        private Point cords;
        private Random rnd;
        public Apple(int mapWidth, int mapHeight, Bitmap picture, Snake snake)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeight;
            Picture = picture;
            rnd = new Random();
            Coordinates = NewCoordinates(snake);
        }
        public int MapHeight
        {
            get { return mapHeight; }
            set
            {
                if (value > 1)
                {
                    mapHeight = value;
                }
            }
        }
        public int MapWidth
        {
            get { return mapWidth; }
            set
            {
                if (value > 1)
                {
                    mapWidth = value;
                }
            }
        }
        public Bitmap? Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public Point Coordinates
        {
            get { return cords; }
            set { cords = value; }
        }
        public Point NewCoordinates(Snake snake)
        {
            Point cords = new Point();
            if (snake.BodyPoints.Count < MapWidth * MapHeight)
            {
                rnd = new Random();
                do
                {
                    cords.X = rnd.Next(0, MapWidth);
                    cords.Y = rnd.Next(0, MapHeight);
                }
                while (snake.IntersectsWith(cords));
            }
            return cords;
        }
        public void Draw(Bitmap screen)
        {
            if(Picture != null)
            {
                Graphics grafon = Graphics.FromImage(screen);
                Point drawingPoint = new Point();
                double cellWidth = (double)screen.Width / mapWidth;
                double cellHeight = (double)screen.Height / mapHeight;
                float size = (float)(cellWidth + cellHeight) / 2;
                drawingPoint.X = (int)(Coordinates.X * cellWidth);
                drawingPoint.Y = (int)(Coordinates.Y * cellHeight);
                grafon.DrawImage(Picture, drawingPoint.X, drawingPoint.Y, size, size);

            }
        }
    }
}
