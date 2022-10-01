using SSnake.Properties;
using System.Data;

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
        int mapWidth = 2, mapHeight = 2;
        int increment = 1;
        int score = 0;
        Color snakeBodyColor = Color.ForestGreen;
        Bitmap appleImage = Resources.ImageApple;
        Bitmap screen;
        Bitmap backgroundImage;
        Graphics grafon;
        DateTime timer = DateTime.MinValue;
        double mapProportion;
        public Form1()
        {
            InitializeComponent();
            snake = new Snake(mapWidth, mapHeight, snakeBodyColor);
            apple = new Apple(mapWidth, mapHeight, appleImage, snake);
            screen = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            backgroundImage = new Bitmap(pictureBoxScreen.ClientSize.Width, pictureBoxScreen.ClientSize.Height);
            grafon = Graphics.FromImage(screen);
            mapHeight = (int)numericUpDownMapHeight.Value;
            mapWidth = (int)numericUpDownMapWidth.Value;
            CalcProportion();
            if (checkBoxMSCS.Checked)
            {
                this.ClientSize = new Size(ClientSize.Width, (int)(pictureBoxScreen.Width * mapProportion));
            }
            DataTable speedTable = new DataTable();
            DataColumn nameColumn = new DataColumn("Name", typeof(string));
            DataColumn valueColumn = new DataColumn("Value", typeof(double));
            speedTable.Columns.Add(nameColumn);
            speedTable.Columns.Add(valueColumn);
            speedTable.Rows.Add("Медленно", 2);
            speedTable.Rows.Add("Нормально", 4);
            speedTable.Rows.Add("Быстро", 8);
            comboBoxSpeed.DisplayMember = "Name";
            comboBoxSpeed.ValueMember = "Value";
            comboBoxSpeed.DataSource = speedTable;
            comboBoxSpeed.SelectedIndex = 1;
            UpdateTable();
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
                if (apple.Coordinates == null)
                {
                    grafon.Clear(Color.Transparent);
                    apple.Draw(screen);
                    snake.Draw(screen);
                    pictureBoxScreen.Image = screen;
                    StopGame();
                    MessageBox.Show($"Вы прошли змейку с полем размером {mapWidth}x{mapHeight} \n" +
                        $"за {timer.ToString("mm:ss")}\n" +
                        $"набрав при этом {score} очка(ов)",
                        "Поздравляем",
                        MessageBoxButtons.OK);
                    return;
                }
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
                        snake.AddMove(Direction.Up);
                        break;
                    case "A":
                        snake.AddMove(Direction.Left);
                        break;
                    case "S":
                        snake.AddMove(Direction.Down);
                        break;
                    case "D":
                        snake.AddMove(Direction.Right);
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
            using (SSnakeContext db = new SSnakeContext())
            {
                Record record = new Record()
                {
                    NickName = "test tesovich",
                    Score = score,
                    TimePassed = timer,
                    MapWidth = mapWidth,
                    MapHeight = mapHeight,
                    SpeedName = ((DataRowView)comboBoxSpeed.SelectedItem).Row[0].ToString(),
                    SpeedValue = (double)comboBoxSpeed.SelectedValue,
                    RecordDateTime = DateTime.Now,
                    SnakeLength = snake.FactLenght
                };
                db.Records.Add(record);
                db.SaveChanges();
            }


            timerTime.Stop();
            buttonStartStop.Text = "Старт";
            timerGameTick.Stop();
            timer = DateTime.MinValue;
            playing = false;
        }

        private void pictureBoxScreen_SizeChanged(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            timer = timer.AddSeconds(1);
            labelTimer.Text = "Время игры: " + timer.ToString("mm:ss");
        }

        private void checkBoxMSCS_CheckedChanged(object sender, EventArgs e)
        {

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

        private void Form1_Resize(object sender, EventArgs e)
        {
            CalcProportion();
            if (checkBoxMSCS.Checked)
            {
                if (this.ClientSize.Height != (int)((pictureBoxScreen.Width - groupBoxMenu.Width) * mapProportion))
                {
                    this.ClientSize = new Size(ClientSize.Width, (int)(pictureBoxScreen.Width * mapProportion));
                }
            }
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
            GC.Collect(1);
        }

        private void tableLayoutPanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerGameTick.Interval = (int)(1000 / (double)comboBoxSpeed.SelectedValue);
            UpdateTable();
        }

        private void groupBoxMenu_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownMapWidth_ValueChanged(object sender, EventArgs e)
        {
            mapWidth = (int)numericUpDownMapWidth.Value;
            Form1_Resize(sender, e);
            UpdateTable();
        }

        private void numericUpDownMapHeight_ValueChanged(object sender, EventArgs e)
        {
            mapHeight = (int)numericUpDownMapHeight.Value;
            Form1_Resize(sender, e);
            UpdateTable();
        }

        private void CalcProportion()
        {
            mapProportion = (double)mapHeight / mapWidth;
        }
        //protected override void OnResize(EventArgs e)
        //{
        //    base.OnResize(e);
        //}
        private void UpdateTable()
        {
            using (SSnakeContext db = new SSnakeContext())
            {
                dataGridViewRecords.Rows.Clear();
                foreach (Record rec in db.Records)
                {
                    if(mapWidth == rec.MapWidth && mapHeight == rec.MapHeight && (double)comboBoxSpeed.SelectedValue == rec.SpeedValue)
                    dataGridViewRecords.Rows.Add(rec.NickName, rec.Score, rec.TimePassed.ToString("mm:ss"));
                }
            }
        }
    }
}