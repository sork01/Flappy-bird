using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird_windows_form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 8;
        int gravity = 15;
        int cloudspeed = 9;
        int cloud2speed = 10;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            cloud.Left -= cloudspeed;
            cloud2.Left -= cloud2speed;
            scoreText.Text = "Score: " + score.ToString();

            if (pipeBottom.Left < -110)
            {
                pipeBottom.Left = 900 + rnd.Next(1,400);
                score++;
            }
            
            if (pipeTop.Left < -100)
            {
                pipeTop.Left = 900 + rnd.Next(1, 400);
                score++;
            }

            if (cloud.Left < -100)
            {
                cloud.Left = 900 + rnd.Next(1, 400);
                cloud.Top = cloud.Top + rnd.Next(-100, 100);
            }

            if (cloud2.Left < -100)
            {
                cloud2.Left = 900 + rnd.Next(1, 400);
                cloud2.Top = cloud2.Top + rnd.Next(-100, 100);
            }
            
            if(bird.Bounds.IntersectsWith(pipeBottom.Bounds) || bird.Bounds.IntersectsWith(pipeTop.Bounds) || bird.Bounds.IntersectsWith(grund.Bounds) || bird.Top < -20)
            {
                endgame();
            }

            if(score == 10)
            {
                pipeSpeed = 9;
            }

            if (score == 20)
            {
                pipeSpeed = 10;
            }

            if (score == 30)
            {
                pipeSpeed = 11;
            }

            if (score == 40)
            {
                pipeSpeed = 18;
            }

            if (score > 50)
            {
                pipeSpeed += 1;
            }

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endgame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over!!";
        }

    }
}
