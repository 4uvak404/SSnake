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
        Snake snake;
        int mapWidth = 20, mapHeight = 20;
        Color snakeBodyColor = Color.IndianRed;
        Bitmap screen;
        Graphics grafon;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            screen = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            grafon = Graphics.FromImage(screen);
        }

        private void timerGameTick_Tick(object sender, EventArgs e)
        {
            snake.MoveForward();
            grafon.Clear(pictureBoxScreen.BackColor);
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

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                snake = new Snake(mapWidth, mapHeight, snakeBodyColor);

                snake.Draw(screen);
                pictureBoxScreen.Image = screen;

                buttonStartStop.Text = "Стоп";
                timerGameTick.Start();
                playing = true;
            }
            else
            {
                StopGame();
            }
        }
        private void StopGame()
        {


            buttonStartStop.Text = "Старт";
            timerGameTick.Stop();
            playing = false;
        }
    }
}