using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Drawing;
//using System.Drawing.Drawing2D;
//using System.Drawing.Imaging;
//using System.Drawing.Text;

namespace SSnake
{
    internal class Snake
    {
        private int mapWidth, mapHeight;
        private int factLenght, wantedLenght;
        private Direction direction;
        private Color bodyColor;
        private List<Point> bodyPoints = new List<Point>(); 
        public Snake(int mapWidth, int mapHeiht, Color bodyColor)
        {
            MapWidth = mapWidth;
            MapHeight = mapHeiht;
            factLenght = 2;
            wantedLenght = 2;
            BodyColor = bodyColor;
            Point pont = new Point();
            pont.X = MapWidth / 2 - 1;
            pont.Y = MapHeight / 2;
            BodyPoints.Add(pont);
            pont.X++;
            BodyPoints.Add(pont);
            Direction = Direction.Right;
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
        private Direction Direction
        {
            get { return direction; }
            set { direction = value; }
            
        }
        private List<Direction> NextMoves { get; set; } = new List<Direction>();
        public Color BodyColor
        {
            get { return bodyColor; }
            set
            {
                bodyColor = value;
            }
        }
        public List<Point> BodyPoints
        {
            get { return bodyPoints; }
            private set { bodyPoints = value; }
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
            bool notCollision = true;
            if(NextMoves.Count > 0)
            {
                Direction = NextMoves[0];
                NextMoves.RemoveAt(0);
            }
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
            Point newHead = Head;
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
            if (BodyPoints.Contains(newHead) || newHead.X < 0 || newHead.X >= MapWidth || newHead.Y < 0 || newHead.Y >= MapHeight)
            {
                notCollision = false;
            }
            BodyPoints.Add (newHead);
            return notCollision;
        }
        public bool IntersectsWith(Point Coordinates)
        {
            if (BodyPoints.Contains(Coordinates)) 
            { 
                return true; 
            }
            else return false;
        }
        public void Draw(Bitmap screen)
        {
            Graphics grafon = Graphics.FromImage(screen);
            PointF[] drawingPoints = new PointF[BodyPoints.Count];
            float cellWidth = (float)screen.Width / mapWidth;
            float cellHeight = (float)screen.Height / mapHeight;
            float penWidth = (Math.Min(cellWidth, cellHeight) - Math.Min(cellWidth, cellHeight) / 100 * 10);
            Pen penPen = new Pen(BodyColor, penWidth);
            penPen.EndCap = System.Drawing.Drawing2D.LineCap.DiamondAnchor;
            for (int i = 0; i < drawingPoints.Length; i++)
            {
                drawingPoints[i].X = cellWidth / 2 + BodyPoints[i].X * cellWidth;
                drawingPoints[i].Y = cellHeight / 2 + BodyPoints[i].Y * cellHeight;
            }
            grafon.DrawLines(penPen, drawingPoints);
        }
        public void AddMove(Direction moveDirection)
        {
            if (NextMoves.Count >= 2) return;
            Direction oldDirection;
            if (NextMoves.Count >= 1)
            {
                oldDirection = NextMoves.Last();
            }
            else
            {
                oldDirection = Direction;
            }

            switch (moveDirection)
            {
                case Direction.Up:
                    if (oldDirection != Direction.Down && oldDirection != moveDirection)
                    {
                        NextMoves.Add(moveDirection);
                    }
                    break;
                case Direction.Right:
                    if (oldDirection != Direction.Left && oldDirection != moveDirection)
                    {
                        NextMoves.Add(moveDirection);
                    }
                    break;
                case Direction.Down:
                    if (oldDirection != Direction.Up && oldDirection != moveDirection)
                    {
                        NextMoves.Add(moveDirection);
                    }
                    break;
                case Direction.Left:
                    if (oldDirection != Direction.Right && oldDirection != moveDirection)
                    {
                        NextMoves.Add(moveDirection);
                    }
                    break;
            }
        }
    }
}
