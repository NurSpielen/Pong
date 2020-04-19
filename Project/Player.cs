using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong

{
    enum Side
    {
        Left = -1,
        Right = 1,
    }

    class Player
    {
        private Side side;

        private PictureBox player;

        private int vel { get; set; }

        private bool moveUp { get; set; }
        private bool moveDown { get; set; }

        public Player(int vel, PictureBox player, Side side )
        {
            this.vel = vel;
            this.player = player;
            this.side = side;
            moveUp = false;
            moveDown = false;
        }

        public void Tick()
        {
            if (moveUp && player.Top >= 4)
            {
                player.Top -= vel;
            }
            if (moveDown && player.Top < Form1.HEIGHT - 180)
            {
                player.Top += vel;
            }
        }

        public void KeyIsDown(KeyEventArgs e)
        {
            if (side == Side.Left)
            {
                if (e.KeyCode == Keys.W)
                {
                    moveUp = true;
                }
                if (e.KeyCode == Keys.S)
                {
                    moveDown = true;
                }
            }
            else if (side == Side.Right)
            {
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    moveDown = true;
                }
            }
        }

        public void KeyIsUp(KeyEventArgs e)
        {
            if (side == Side.Left)
            {
                if (e.KeyCode == Keys.W)
                {
                    moveUp = false;
                }
                if (e.KeyCode == Keys.S)
                {
                    moveDown = false;
                }
            }
            else if (side == Side.Right)
            {
                if (e.KeyCode == Keys.Up)
                {
                    moveUp = false;
                }
                if (e.KeyCode == Keys.Down)
                {
                    moveDown = false;
                }
            }
        }
    }
}
