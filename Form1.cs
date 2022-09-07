using SSnake.Properties;

namespace SSnake
{
    enum Direction
    {
        Up,
        Right,
        Down,
        Left
    }
    public partial class Form1 : Form
    {
        bool playing = false;
        bool played = false;
        Snake snake;
        Apple apple;
        int mapWidth = 20, mapHeight = 15;
        int increment = 1;
        int score = 0;
        Color snakeBodyColor = Color.ForestGreen;
        Bitmap appleImage = Resources.ImageApple;
        Bitmap screen;
        Bitmap backgroundImage;
        Graphics grafon;
        DateTime timer = DateTime.MinValue;
        public Form1()
        {
            InitializeComponent();
            snake = new Snake(mapWidth, mapHeight, snakeBodyColor);
            apple = new Apple(mapWidth, mapHeight, appleImage, snake);
            screen = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            backgroundImage = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            grafon = Graphics.FromImage(screen);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DrawBackground();
        }

        private void TimerGameTick_Tick(object sender, EventArgs e)
        {
            if (!snake.MoveForward()) 
            { 
                StopGame();
            }
            if (snake.IntersectsWith(apple.Coordinates))
            {
                snake.WantedLenght += increment;
                score++;
                labelScore.Text = "Очки: " + score.ToString();
                apple.Coordinates = apple.NewCoordinates(snake);
            }
            grafon.Clear(Color.Transparent);
            apple.Draw(screen);
            snake.Draw(screen);

            pictureBoxScreen.Image = screen;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (snake != null)
            {
                switch (e.KeyCode.ToString())
                {
                    case "W":
                        snake.NewDirection = Direction.Up;
                        break;
                    case "A":
                        snake.NewDirection = Direction.Left;
                        break;
                    case "S":
                        snake.NewDirection = Direction.Down;
                        break;
                    case "D":
                        snake.NewDirection = Direction.Right;
                        break;
                }
            }
            
        }

        private void ButtonStartStop_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                snake = new Snake(mapWidth, mapHeight, snakeBodyColor);
                apple = new Apple(mapWidth, mapHeight, appleImage, snake);
                score = 0;
                labelScore.Text = "Очки: 0";
                labelTimer.Text = "Время игры: 00:00";

                grafon.Clear(Color.Transparent);
                apple.Draw(screen);
                snake.Draw(screen);
                pictureBoxScreen.Image = screen;

                buttonStartStop.Text = "Стоп";
                timerTime.Start();
                timerGameTick.Start();
                played = true;
                playing = true;
            }
            else
            {
                StopGame();
            }
        }
        private void StopGame()
        {

            timerTime.Stop();
            buttonStartStop.Text = "Старт";
            timerGameTick.Stop();
            timer = DateTime.MinValue;
            playing = false;
        }

        private void pictureBoxScreen_SizeChanged(object sender, EventArgs e)
        {
            //screen.Dispose();
            screen = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            grafon = Graphics.FromImage(screen);
            //backgroundImage.Dispose();
            backgroundImage = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            grafon.Clear(Color.Transparent);
            if (played)
            {
                apple.Draw(screen);
                snake.Draw(screen);
                pictureBoxScreen.Image = screen;
            }
            DrawBackground();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            timer = timer.AddSeconds(1);
            labelTimer.Text = "Время игры: " + timer.ToString("mm:ss");
        }

        private void DrawBackground()
        {
            Graphics background = Graphics.FromImage(backgroundImage);
            SolidBrush bruh = new SolidBrush(Color.LightGreen);
            background.Clear(Color.PaleGreen);
            float cellWidth = (float)screen.Width / mapWidth;
            float cellHeight = (float)screen.Height / mapHeight;
            for (int y = 0; y < mapHeight; y++)
            {
                for (int x = 0; x < mapWidth; x++)
                {
                    if ((x + y) % 2 == 0)
                    {
                        background.FillRectangle(bruh, x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                    }
                }
            }
            pictureBoxScreen.BackgroundImage = backgroundImage;
        }
    }
}