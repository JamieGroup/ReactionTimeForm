using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ReactionTime
{
    public partial class frmReaction : Form
    {
        int counter = 0;
        int countertotal = 0;
        int attempts = 0;
        int avgScore = 0;
        int[] scoreAttempts = new int[5];
        int clicked = 0;
        Random rnd = new Random();

        public frmReaction()
        {
            InitializeComponent();
            btnClick.Visible = false;
            btnClick2.Visible = false;
            lbAverageScore.Visible = false;
            lbScore.Text = "Time: ";
            lbAttempts.Text = "You have five attempts. Good Luck.";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            buttonAppears();
            buttonAppears2();
            tmrTimer.Start();
            counter = 0;
            attempts++;
            lbAttempts.Text = "Attempt: " + attempts.ToString();
        }

        public void buttonAppears()
        {
            //Create a button object
            //Button rButton = new Button();

            //Set Button properties
            btnClick.Height = 30;
            btnClick.Width = 60;
            btnClick.ForeColor = Color.Blue;

            
            int yAxis = rnd.Next(100, 500); //creates a random number between 100 and 500
            int xAxis = rnd.Next(100, 500); //creates a random number between 100 and 500

            btnClick.Location = new Point(xAxis, yAxis);
            btnClick.Visible = true; 

            //rButton.Text = "click me";
            //rButton.Name = "rButton";
            //rButton.Font = new Font("arial", 8);
        }

        public void buttonAppears2()
        {
            //Create a button object
            //Button rButton = new Button();

            //Set Button properties
            btnClick2.Height = 30;
            btnClick2.Width = 60;
            btnClick2.ForeColor = Color.Blue;

            
            int yAxis2 = rnd.Next(100, 500); //creates a random number between 100 and 500
            int xAxis2 = rnd.Next(100, 500); //creates a random number between 100 and 500

            btnClick2.Location = new Point(xAxis2, yAxis2);
            btnClick2.Visible = true;

            //rButton.Text = "click me";
            //rButton.Name = "rButton";
            //rButton.Font = new Font("arial", 8);
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            clicked++;
            if (clicked == 2);
            {
                tmrTimer.Stop();
                btnClick.Visible = false;

                lbScore.Text = "Times Up";
                MessageBox.Show($"Your time was: {counter.ToString()}");
                scoreAttempts[attempts - 1] = counter;
                MessageBox.Show("Just checking: " + scoreAttempts[attempts - 1].ToString());

                if (attempts == 5)
                {
                    btnStart.Enabled = false;
                    MessageBox.Show("You have had five attempts.");
                    for (int i = 0; i < 5; i++)
                    {
                        avgScore += scoreAttempts[i];
                    }
                    avgScore = avgScore / 5;
                    MessageBox.Show($"Your average score is: {avgScore.ToString()}");
                }
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);
            counter++;
            lbScore.Text = ($"Time: {counter.ToString()}");
        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            clicked++;
            if (clicked == 2);
            {
                btnClick2.Visible = false;

                lbScore.Text = "Times Up";
                MessageBox.Show($"Your time was: {counter.ToString()}");
                scoreAttempts[attempts - 1] = counter;
                MessageBox.Show("Just checking: " + scoreAttempts[attempts - 1].ToString());

                if (attempts == 5)
                {
                    btnStart.Enabled = false;
                    MessageBox.Show("You have had five attempts.");
                    for (int i = 0; i < 5; i++)
                    {
                        avgScore += scoreAttempts[i];
                    }
                    avgScore = avgScore / 5;
                    MessageBox.Show($"Your average score is: {avgScore.ToString()}");
                }
                else
                {

                }
            }
        }
    }
}