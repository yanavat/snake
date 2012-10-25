using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        Image[] diceimage;
        int[] dice;
        Random rand;
        public Form1()
        {
            InitializeComponent();
        }
        private int b = 0;
        private int a = 0;
        public int randomNumber = 1;
        private int s = 0;
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

 

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            randomNumber = s;
            
            foreach (PictureBox picBox in this.Controls.OfType<PictureBox>())
            {
                this.Controls.Find("a" + (a + 1).ToString(), false).ElementAt(0).Visible = false;
            }
            a = a + randomNumber;
            if (a==10)
            {
                a = 4;
                a5.Visible = true;
            }
            else if (a == 15)
            {
                a = 30;
                a32.Visible = true;
            }
            else if (a == 42)
            {
                a = 27;
                a28.Visible = true;
            }
            else if (a == 47)
            {
                a = 35;
                a36.Visible = true;
            }
            else
            {
                textBox1.Text = Convert.ToString(a);       
                this.Controls.Find("a" + (a + 1).ToString(), false).ElementAt(0).Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            randomNumber = s;

            foreach (PictureBox picBox in this.Controls.OfType<PictureBox>())
            {
                this.Controls.Find("b" + (b + 1).ToString(), false).ElementAt(0).Visible = false;
            }
            b = b + randomNumber;
            if (b == 10)
            {
                b = 4;
                b5.Visible = true;
            }
            else if (b == 15)
            {
                b = 30;
                b32.Visible = true;
            }
            else if (b == 42)
            {
                b = 27;
                b28.Visible = true;
            }
            else if (b == 47)
            {
                b = 35;
                b36.Visible = true;
            }
            else
            {
                textBox1.Text = Convert.ToString(b);
                this.Controls.Find("b" + (b + 1).ToString(), false).ElementAt(0).Visible = true;
            }
        }


            
      

   

        private void button3_Click(object sender, EventArgs e)
        {
            //Random nam1 = new Random();
            //randomNumber = nam1.Next(1, 7);
            //this.label1.Text = randomNumber.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceimage = new Image[7];
            diceimage[0] = Properties.Resources.dice_0;
            diceimage[1] = Properties.Resources.dice_1;
            diceimage[2] = Properties.Resources.dice_2;
            diceimage[3] = Properties.Resources.dice_3;
            diceimage[4] = Properties.Resources.dice_4;
            diceimage[5] = Properties.Resources.dice_5;
            diceimage[6] = Properties.Resources.dice_6;

            dice = new int[1] { 0 };

            rand = new Random();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            RollDice();
        }

       public void RollDice() 
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);

                label_dice.Image = diceimage[dice[0]];
                 s = dice[i];
                this.label1.Text = Convert.ToString(s);
            }
        }
    }
}
