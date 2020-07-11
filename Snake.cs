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
            this.AddPixel(200, 200);
            this.AddPixel(200, 220);
            this.AddPixel(200, 240);
        }
        private void AddPixel(int left, int top)
        {
                PictureBox snakePixel;
                snakePixel = new PictureBox();

                snakePixel.Height = 20;
                snakePixel.Width = 20;
                snakePixel.BackColor = Color.Red;
            snakePixel.Left = left;
                snakePixel.Top = top;

                snakePixels.Add(snakePixel);
        }
        

        public void Render(Form form)
        {
            foreach (var sp in snakePixels)
            {
                form.Controls.Add(sp);
                sp.BringToFront();
            }
            // fom.Controls.Add(snakePixels[0]); - add one pixel /picture box/
        }
    }
}
