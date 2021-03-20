using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace memorygamewithpicture
{
    public partial class Gameboard : Form
    {
        int score = 0;
        Random pos = new Random();
        List<int> X = new List<int>();
        List<int> Y = new List<int>();
        List<Point> points = new List<Point>();
        bool again = false;
        PictureBox fistclicked;
        PictureBox secondclicked;

        public Gameboard()
        {
            InitializeComponent();
        }

        private void Gameboard_Load(object sender, EventArgs e)
        {
            label1.Text = "5";
            foreach(PictureBox picture in Cardholder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in Cardholder.Controls)
            {
                int next = pos.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            timer1.Start();
            timer2.Start();
            card1.Image = Properties.Resources.img1;
            durpcard1.Image = Properties.Resources.img1;
            card2.Image = Properties.Resources.img2;
            durpcard2.Image = Properties.Resources.img2;
            card3.Image = Properties.Resources.img3;
            durpcard3.Image = Properties.Resources.img3;
            card4.Image = Properties.Resources.img4;
            durpcard4.Image = Properties.Resources.img4;
            card5.Image = Properties.Resources.img5;
            durpcard5.Image = Properties.Resources.img5;
            card6.Image = Properties.Resources.img6;
            durpcard6.Image = Properties.Resources.img6;
            card7.Image = Properties.Resources.img7;
            durpcard7.Image = Properties.Resources.img7;
            card8.Image = Properties.Resources.img8;
            durpcard8.Image = Properties.Resources.img8;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in Cardholder.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources.quiez;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer - 1;
            label1.Text = Convert.ToString(timer);
            if (timer < 1) timer2.Stop();
        }
        #region stupidcopy
        private void card1_Click(object sender, EventArgs e)
        {
            if (fistclicked == null)
            {
                fistclicked = card1;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card1;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card1.Enabled = false;
                    durpcard1.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else 
                {
                    MessageBox.Show("You are loser");
                    this.Close();
                    timer3.Start();
                }
            
            }
            card1.Image = Properties.Resources.img1;
        }

        private void durpcard1_Click(object sender, EventArgs e)
        {
            durpcard1.Image = Properties.Resources.img1;
            if (fistclicked == null)
            {
                fistclicked = durpcard1;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card1;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card1.Enabled = false;
                    durpcard1.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
                
            }
        }

        private void card2_Click(object sender, EventArgs e)
        {
            card2.Image = Properties.Resources.img2;
            if (fistclicked == null)
            {
                fistclicked = card2;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card2;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card2.Enabled = false;
                    durpcard2.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
             
            }
        }

        private void durpcard2_Click(object sender, EventArgs e)
        {
            durpcard2.Image = Properties.Resources.img2;
            if (fistclicked == null)
            {
                fistclicked = durpcard2;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard2;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card2.Enabled = false;
                    durpcard2.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            
            }
        }

        private void card3_Click(object sender, EventArgs e)
        {
            card3.Image = Properties.Resources.img3;
            if (fistclicked == null)
            {
                fistclicked = card3;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card3;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card3.Enabled = false;
                    durpcard3.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
             
            }
        }

        private void durpcard3_Click(object sender, EventArgs e)
        {
            durpcard3.Image = Properties.Resources.img3;
            if (fistclicked == null)
            {
                fistclicked = durpcard3;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard3;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card3.Enabled = false;
                    durpcard3.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
        
            }
        }

        private void card4_Click(object sender, EventArgs e)
        {
            card4.Image = Properties.Resources.img4;
            if (fistclicked == null)
            {
                fistclicked = card4;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card4;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card4.Enabled = false;
                    durpcard4.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
           
            }
        }

        private void durpcard4_Click(object sender, EventArgs e)
        {
            durpcard4.Image = Properties.Resources.img4;
            if (fistclicked == null)
            {
                fistclicked = durpcard4;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard4;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card4.Enabled = false;
                    durpcard4.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
              
            }
        }

        private void card5_Click(object sender, EventArgs e)
        {
            card5.Image = Properties.Resources.img5;
            if (fistclicked == null)
            {
                fistclicked = card5;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card5;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card5.Enabled = false;
                    durpcard5.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
              
            }
        }

        private void durpcard5_Click(object sender, EventArgs e)
        {
            durpcard5.Image = Properties.Resources.img5;
            if (fistclicked == null)
            {
                fistclicked = durpcard5;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard5;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card5.Enabled = false;
                    durpcard5.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }

            }
        }

        private void card6_Click(object sender, EventArgs e)
        {
            card6.Image = Properties.Resources.img6;
            if (fistclicked == null)
            {
                fistclicked = card6;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card6;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card6.Enabled = false;
                    durpcard6.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void durpcard6_Click(object sender, EventArgs e)
        {
            durpcard6.Image = Properties.Resources.img6;
            if (fistclicked == null)
            {
                fistclicked = durpcard6;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard6;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card6.Enabled = false;
                    durpcard6.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }

            }
        }

        private void card7_Click(object sender, EventArgs e)
        {
            card7.Image = Properties.Resources.img7;
            if (fistclicked == null)
            {
                fistclicked = card7;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card7;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card7.Enabled = false;
                    durpcard7.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }

            }
        }

        private void durpcard7_Click(object sender, EventArgs e)
        {
            durpcard7.Image = Properties.Resources.img7;
            if (fistclicked == null)
            {
                fistclicked = durpcard7;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard7;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card7.Enabled = false;
                    durpcard7.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }

            }
        }

        private void card8_Click(object sender, EventArgs e)
        {
            card8.Image = Properties.Resources.img8;
            if (fistclicked == null)
            {
                fistclicked = card8;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = card8;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card8.Enabled = false;
                    durpcard8.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }

            }
        }

        private void durpcard8_Click(object sender, EventArgs e)
        {
            durpcard8.Image = Properties.Resources.img8;
            if (fistclicked == null)
            {
                fistclicked = durpcard8;
            }
            else if (fistclicked != null && secondclicked == null)
            {
                secondclicked = durpcard8;
            }
            if (fistclicked != null && secondclicked != null)
            {
                if (fistclicked.Tag == secondclicked.Tag)
                {
                    fistclicked = null;
                    secondclicked = null;
                    card8.Enabled = false;
                    durpcard8.Enabled = false;
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) + 10);
                }
                else
                {
                    scorecounter.Text = Convert.ToString(Convert.ToInt32(scorecounter.Text) - 10);
                    timer3.Start();
                }
            }
        }
        #endregion
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            fistclicked.Image = Properties.Resources.quiez;
            secondclicked.Image = Properties.Resources.quiez;
            fistclicked = null;
            secondclicked = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gameboard_Load(sender, e);
        }







    }
}
