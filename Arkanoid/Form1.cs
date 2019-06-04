using System;
using System.Drawing;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class Form1 : Form
    {
        Image ball = Image.FromFile("../../images/ball.png");
        Point ballPoint;
        Point vesselPoint;
        int speedX;
        int speedY = 7;
        int count = 0;
        int score = 0;
        bool paused = true;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ballPoint = new Point(rand.Next(ClientSize.Width - 100), -100);
            vesselPoint.X = ClientSize.Width / 2 - 150;
            vesselPoint.Y = ClientSize.Height - 50;
            speedX = rand.Next(6, 7) == 6 ? -7 : 7;
            labelPause.Visible = false;
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ball, ballPoint.X, ballPoint.Y, 100, 100);
            e.Graphics.DrawRectangle(new Pen(Color.Black, 5), vesselPoint.X, vesselPoint.Y, 300, 50);
            e.Graphics.FillRectangle(Brushes.Red, vesselPoint.X, vesselPoint.Y, 300, 50);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && !paused)
            {
                vesselPoint.X -= 20;
            }
            else if (e.KeyCode == Keys.Right && !paused)
            {
                vesselPoint.X += 20;
            }
            if (e.KeyCode == Keys.Space && paused)
            {
                timer1.Start();
                paused = false;
                labelPause.Visible = false;
                labelStart.Visible = false;
                Cursor.Hide();
            }
            else if (e.KeyCode == Keys.Space && !paused)
            {
                timer1.Stop();
                paused = true;
                labelPause.Visible = true;
                Cursor.Show();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (ballPoint.Y + 100 >= vesselPoint.Y)
            {
                if (ballPoint.X + 50 >= vesselPoint.X + 120 && ballPoint.X + 50 <= vesselPoint.X + 180)
                {
                    speedX = 5 * Math.Sign(speedX);
                    speedY = -Math.Abs(speedY);
                    count++;
                    score += 5;
                }
                else if (ballPoint.X + 50 >= vesselPoint.X + 90 && ballPoint.X + 50 <= vesselPoint.X + 210)
                {
                    speedX = 6 * Math.Sign(speedX);
                    speedY = -Math.Abs(speedY);
                    count++;
                    score += 4;
                }
                else if (ballPoint.X + 50 >= vesselPoint.X + 60 && ballPoint.X + 50 <= vesselPoint.X + 240)
                {
                    speedX = 7 * Math.Sign(speedX);
                    speedY = -Math.Abs(speedY);
                    count++;
                    score += 3;
                }
                else if (ballPoint.X + 50 >= vesselPoint.X + 30 && ballPoint.X + 50 <= vesselPoint.X + 270)
                {
                    speedX = 8 * Math.Sign(speedX);
                    speedY = -Math.Abs(speedY);
                    count++;
                    score += 2;
                }
                else if (ballPoint.X + 50 >= vesselPoint.X && ballPoint.X + 50 <= vesselPoint.X + 300)
                {
                    speedX = 9 * Math.Sign(speedX);
                    speedY = -Math.Abs(speedY);
                    count++;
                    score += 1;
                }
            }

            if (ballPoint.Y < 0)
            {
                speedY = Math.Abs(speedY);
            }
            if (ballPoint.X + 100 >= ClientRectangle.Right)
            {
                speedX = -Math.Abs(speedX);
            }
            if (ballPoint.X <= 0)
            {
                speedX = Math.Abs(speedX);
            }

            if (vesselPoint.X <= 0)
            {
                vesselPoint.X = 0;
            }
            if (vesselPoint.X + 300 >= ClientRectangle.Right)
            {
                vesselPoint.X = ClientRectangle.Right - 300;
            }

            ballPoint.X += speedX;
            ballPoint.Y += speedY;

            labelCount.Text = "Отбиваний: " + count;
            labelScore.Text = "Очков: " + score;
            Refresh();

            if (ballPoint.Y + 100 >= ClientRectangle.Bottom)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            timer1.Stop();
            Cursor.Show();
            string str = string.Format("Игра окончена!\nОтбиваний: {1}\nОчков: {0}", score, count);
            DialogResult result = MessageBox.Show(str, "Game over");
            if (result == DialogResult.OK)
            {
                ballPoint = new Point(rand.Next(ClientSize.Width - 100), -100);
                vesselPoint.X = ClientSize.Width / 2 - 150;
                vesselPoint.Y = ClientSize.Height - 50;
                speedX = rand.Next(4, 5) == 4 ? -5 : 5;
                count = 0;
                score = 0;
                paused = true;
                labelStart.Visible = true;
                Refresh();
            }
        }
    }
}