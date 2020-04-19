using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    class Ball
    {
        private PictureBox ball;

        private int xSpeed;
        private int ySpeed;

        public Ball(int xSpeed, int ySpeed, PictureBox ball)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
            this.ball = ball;
        }

        public void Tick()
        {
            ball.Top += ySpeed;
            ball.Left += xSpeed;

            if (ball.Top <= 0 || ball.Top >= Form1.HEIGHT - 110)
            {
                ySpeed *= -1;
            }
            if (ball.Left <= 0 || ball.Left >= Form1.WIDTH - 220)
            {
                xSpeed *= -1;
            }
        }
    }
}
