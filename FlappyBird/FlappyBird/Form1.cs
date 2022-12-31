using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 5 ;
        int gravity = 9;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipebottom.Left -= pipeSpeed;
            pipetop.Left -= pipeSpeed;
            scoretext.Text = "Score:" + score;

            if(pipebottom.Left < -50)
            {
                pipebottom.Left = 800;
                score++;
            }

            if (pipetop.Left < -80)
            {
                pipetop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipebottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipetop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                endGame();

            }

            if(score > 5)
            {

                pipeSpeed = 15;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -9;

            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity =9;

            }
        }

        private void endGame()
        {
            gametimer.Stop();
            scoretext.Text += "Game Over!!!"; 
        }
    }
}
