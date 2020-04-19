using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {

        public static int WIDTH = 782;
        public static int HEIGHT = 453;

        private Player leftPlayer;
        private Player rightPlayer;

        private Ball gameBall;

        private int paddleSpeed = 10;
        private int ballXSpeed = 5;
        private int ballYSpeed = 4;

        public Form1()
        {
            InitializeComponent();
            // Initializing players
            leftPlayer = new Player(paddleSpeed, leftPaddle, Side.Left);
            rightPlayer = new Player(paddleSpeed, rightPaddle, Side.Right);
            gameBall = new Ball(ballXSpeed, ballYSpeed, ball);
            button1.Visible = false;
        }

        private void Tick(object sender, EventArgs e)
        {
            leftPlayer.Tick();
            rightPlayer.Tick();
            gameBall.Tick();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            rightPlayer.KeyIsDown(e);
            leftPlayer.KeyIsDown(e);
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            leftPlayer.KeyIsUp(e);
            rightPlayer.KeyIsUp(e);
        }
    }
}
