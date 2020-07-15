using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Game : Form
    {

        Area area = new Area();
        Snake snake = new Snake();
        Timer mainTimer = new Timer();
        // Food = new food

        public Game()
        {
            InitializeComponent();
            InitializeGame();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            mainTimer.Interval = 500;
            mainTimer.Tick += new EventHandler(MainTimer_Tick);
            mainTimer.Start();
        }

        // private void GenerateFood()
        // can call food again if it is generated on body
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            snake.Move();
        }

        private void InitializeGame()
        {
            this.Height = 600;
            this.Width = 600;

           this.Controls.Add(area);

            area.Top = 50;
            area.Left = 50;
                     // area.Location = new Point(100,100);

            snake.Render(this);
            this.KeyDown += new KeyEventHandler(Game_KeyDown);
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (snake.HorizontalVelocity != -1)
                    {
                        snake.HorizontalVelocity = 1;
                    }
                    snake.VerticalVelocity = 0;
                    break;
                case Keys.Left:
                    if (snake.HorizontalVelocity != 1)
                    {
                        snake.HorizontalVelocity = -1;
                    }
                    snake.VerticalVelocity = 0;
                    break;
                case Keys.Down:
                    snake.HorizontalVelocity = 0;
                    if (snake.VerticalVelocity != -1)
                    {
                        snake.VerticalVelocity = 1;
                    }
                    break;
                case Keys.Up:
                    snake.HorizontalVelocity = 0;
                    if (snake.VerticalVelocity != 1)
                    {
                        snake.VerticalVelocity = -1;
                    }
                    break;
            }
        }




        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
