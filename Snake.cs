using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame
{
    class Snake
    {
        List<PictureBox> snakePixels = new List<PictureBox>();

        public Snake()
        {
            InitializeSnake();
        }

        private void InitializeSnake()
        {
            PictureBox snakePixel = new PictureBox();
            snakePixel.Height = 20;
            snakePixel.Width = 20;
            snakePixel.BackColor = Color.Red;
            snakePixels.Add(snakePixel);
        }
    }
}
