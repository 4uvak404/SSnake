using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSnake
{
    internal class Apple
    {
        private int mapHeight;
        private int mapWidth;
        private Bitmap picture;
        private Point cords;
        private Random rnd;

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
