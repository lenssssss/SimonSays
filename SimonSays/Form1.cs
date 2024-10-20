using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace SimonSays
{
    public partial class Form1 : Form
    {
        int nr = 0;
        Random r;
        int record;
        bool talk = false;
        List<int> ls;

        public Form1()
        {
            r = new Random();
            ls = new List<int>();
            InitializeComponent();
        }

        void Simon_Talk()
        {
            talk = true;
            Thread.Sleep(150);

            foreach (int x in ls)
            {
                switch (x)
                {
                    case 0:
                        pb_Red.Image = Properties.Resources.R2;
                        Thread.Sleep(150);
                        pb_Red.Image = Properties.Resources.R1;
                        break;
                    case 1:
                        pb_Yellow.Image = Properties.Resources.Y2;
                        Thread.Sleep(150);
                        pb_Yellow.Image = Properties.Resources.Y1;
                        break;
                    case 2:
                        pb_Blue.Image = Properties.Resources.B2;
                        Thread.Sleep(150);
                        pb_Blue.Image = Properties.Resources.B1;
                        break;
                    case 3:
                        pb_Green.Image = Properties.Resources.G2;
                        Thread.Sleep(150);
                        pb_Green.Image = Properties.Resources.G1;
                        break;
                }
                Thread.Sleep(150);
            }

            talk = false;
        }

        void verify_Sequence(int btn_pressed)
        {
            if (talk == false && ls.Count > 0)
            {
                if (nr >= ls.Count)
                {
                    MessageBox.Show("Game Over! There were not that many sequences!");
                    nr = 0;
                    ls.Clear();
                }
                else if (btn_pressed == ls[nr])
                {
                    nr++;
                }
                else
                {
                    MessageBox.Show("Game Over!");
                    nr = 0;
                    ls.Clear();
                }
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            lb_score.Text = "Score: " + nr;
            if (nr > record)
            {
                record = nr;
                lb_highscore.Text = "High Score:" + record;
            }
            ls.Add(r.Next(0, 4));
            new Thread(Simon_Talk).Start();
            nr = 0;
        }

        private void pb_Red_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Red.Image = Properties.Resources.R2;
        }

        private void pb_Red_MouseUp(object sender, MouseEventArgs e)
        {
            pb_Red.Image = Properties.Resources.R1;
        }

        private void pb_Yellow_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Yellow.Image = Properties.Resources.Y2;
        }

        private void pb_Yellow_MouseUp(object sender, MouseEventArgs e)
        {
            pb_Yellow.Image = Properties.Resources.Y1;
        }

        private void pb_Blue_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Blue.Image = Properties.Resources.B2;
        }

        private void pb_Blue_MouseUp(object sender, MouseEventArgs e)
        {
            pb_Blue.Image = Properties.Resources.B1;
        }

        private void pb_Green_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Green.Image = Properties.Resources.G2;
        }

        private void pb_Green_MouseUp(object sender, MouseEventArgs e)
        {
            pb_Green.Image = Properties.Resources.G1;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            int value;

            switch (pb.Name)
            {
                case "pb_Red":
                    value = 0;
                    break;
                case "pb_Yellow":
                    value = 1;
                    break;
                case "pb_Blue":
                    value = 2;
                    break;
                case "pb_Green":
                    value = 3;
                    break;
                default:
                    value = -1; // Handle invalid case if necessary
                    break;
            }

            if (value != -1) // Ensure only valid values are passed
            {
                verify_Sequence(value);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.saved_value = record;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            record = Properties.Settings.Default.saved_value;
            lb_highscore.Text ="High Score:" + record;
        }
    }
}
