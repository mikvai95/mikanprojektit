﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace breakoutgame
{
    public partial class Form1 : Form
    {
        bool goRight;
        bool goLeft;
        int speed = 5;

        int ballx = 5;
        int bally = 5;

        int score = 0;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Block")
                {
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    x.BackColor = randomColor;
                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && player.Left > 0)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right && player.Right > 0)
            {
                goRight = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += ballx;
            ball.Top += bally;
            label1.Text = "Score: " + score;

            if (goLeft)
            {
                player.Left -= speed;
            }

            if (goRight)
            {
                player.Left += speed;
            }

            if (player.Left < 1)
            {
                goLeft = false;
            }

            else if (player.Left + player.Width > 920)
            {
                goRight = false;
            }

            if (ball.Left + ball.Width > ClientSize.Width || ball.Left < 0)
            {
                ballx = -ballx;
            }

            if (ball.Top < 0 || ball.Bounds.IntersectsWith(player.Bounds))
            {
                bally = -bally;
            }

            if (ball.Top + ball.Height > ClientSize.Height)
            {
                gameOver();
                pelaaUudelleen.Visible = true;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Block")
                {
                    if (ball.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        bally = -bally;
                        score++;
                    }
                }
            }
            if (score > 34)
            {
                gameOver();
                MessageBox.Show("Hienoa, rikoit kaikki tiilet!");
                pelaaUudelleen.Visible = true;
            }
        }

        private void gameOver()
        {
            timer1.Stop();
        }

        private void pelaaUudelleen_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}