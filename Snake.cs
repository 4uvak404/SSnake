using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSnake
{
    internal class Snake
    {
        private int mapWidth, mapHeight;
        private int factLenght, wantedLenght;
        private Direction direction;
        private Color bodyColor;
        private List<Point> bodyPoints = new List<Point>();

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
        public int FactLenght
        {
            get { return factLenght; }
            private set
            {
                if (value > 0)
                {
                    factLenght = value;
                }
            }
        }
        public int WantedLenght
        {
            get { return wantedLenght; }
            set
            {
                if (value > 0)
                {
                    wantedLenght = value;
                }
            }
        }
        public Direction Direction
        {
            get { return direction; }
            set
            {
                switch (value)
                {
                    case Direction.Up:
                        if (direction != Direction.Down)
                        {
                            direction = value;
                        }
                        break;
                    case Direction.Right:
                        if (direction != Direction.Left)
                        {
                            direction = value;
                        }
                        break;
                    case Direction.Down:
                        if (direction != Direction.Right)
                        {
                            direction = value;
                        }
                        break;
                    case Direction.Left:
                        if (direction != Direction.Left)
                        {
                            direction = value;
                        }
                        break;
                }
            }
        }
        public Color BodyColor
        {
            get { return bodyColor; }
            set
            {
                bodyColor = value;
            }
        }
        private List<Point> BodyPoints
        {
            get { return bodyPoints; }
            set { bodyPoints = value; }
        }
        public Point Head
        {
            get
            {
                return BodyPoints.Last();
            }
        }
        public bool MoveForward()
        {
            bool notCollision;
            if (FactLenght == WantedLenght)
            {
                BodyPoints.RemoveAt(0);
            }
            else if (FactLenght < WantedLenght)
            {
                FactLenght++;
            }
            else
            {
                int i = FactLenght - WantedLenght + 1;
                BodyPoints.RemoveRange(0, i);
                FactLenght = WantedLenght;
            }
            Point newHead = new Point(0,0);
            switch (Direction)
            {
                case Direction.Up:
                    newHead.Y = Head.Y - 1;
                    break;
                case Direction.Right:
                    newHead.X = Head.X + 1;
                    break;
                case Direction.Down:
                    newHead.Y = Head.Y + 1;
                    break;
                case Direction.Left:
                    newHead.X = Head.X - 1;
                    break;
            }
            if (BodyPoints.Contains(newHead))
            {
                notCollision = false;
            }
            else
            {
                notCollision = true;
            }
            BodyPoints.Add (newHead);
            return notCollision;
        }
    }
}
