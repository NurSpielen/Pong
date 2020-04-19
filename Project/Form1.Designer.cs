namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.rightPaddle = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.leftPaddle = new System.Windows.Forms.PictureBox();
            this.rightScore = new System.Windows.Forms.Label();
            this.leftScore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.rightPaddle);
            this.panel.Controls.Add(this.ball);
            this.panel.Controls.Add(this.leftPaddle);
            this.panel.Controls.Add(this.rightScore);
            this.panel.Controls.Add(this.leftScore);
            this.panel.Controls.Add(this.button1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(782, 453);
            this.panel.TabIndex = 0;
            this.panel.Tag = "field";
            // 
            // rightPaddle
            // 
            this.rightPaddle.Image = global::Pong.Properties.Resources.Player;
            this.rightPaddle.Location = new System.Drawing.Point(722, 176);
            this.rightPaddle.Name = "rightPaddle";
            this.rightPaddle.Size = new System.Drawing.Size(30, 100);
            this.rightPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.rightPaddle.TabIndex = 2;
            this.rightPaddle.TabStop = false;
            // 
            // ball
            // 
            this.ball.Image = global::Pong.Properties.Resources.Ball;
            this.ball.Location = new System.Drawing.Point(376, 211);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // leftPaddle
            // 
            this.leftPaddle.Image = global::Pong.Properties.Resources.Player;
            this.leftPaddle.Location = new System.Drawing.Point(30, 176);
            this.leftPaddle.Name = "leftPaddle";
            this.leftPaddle.Size = new System.Drawing.Size(30, 100);
            this.leftPaddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.leftPaddle.TabIndex = 2;
            this.leftPaddle.TabStop = false;
            // 
            // rightScore
            // 
            this.rightScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightScore.ForeColor = System.Drawing.Color.White;
            this.rightScore.Location = new System.Drawing.Point(573, 30);
            this.rightScore.Name = "rightScore";
            this.rightScore.Size = new System.Drawing.Size(26, 29);
            this.rightScore.TabIndex = 1;
            this.rightScore.Text = "0";
            // 
            // leftScore
            // 
            this.leftScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftScore.ForeColor = System.Drawing.Color.White;
            this.leftScore.Location = new System.Drawing.Point(182, 30);
            this.leftScore.Name = "leftScore";
            this.leftScore.Size = new System.Drawing.Size(26, 29);
            this.leftScore.TabIndex = 1;
            this.leftScore.Text = "0";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(353, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 25;
            this.GameTimer.Tick += new System.EventHandler(this.Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.panel);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightPaddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftPaddle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label rightScore;
        private System.Windows.Forms.Label leftScore;
        private System.Windows.Forms.PictureBox rightPaddle;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox leftPaddle;
        private System.Windows.Forms.Timer GameTimer;
    }
}

