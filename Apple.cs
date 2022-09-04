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
        private Bitmap picture;
        private Point cords;
        private Random rnd;
        public Apple(int mapWidth, int mapHeight, Bitmap picture)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeight;
            Picture = picture;
            rnd = new Random();
            cords.X = rnd.Next(0,MapWidth);
            cords.Y = rnd.Next(0,MapHeight);
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
        public Bitmap Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public Point Coordinates
        {
            get { return cords; }
            set { cords = value; }
        }
    }
}
