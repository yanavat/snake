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
            button4.Enabled = true;
            randomNumber = s;
            System.Media.SoundPlayer playerup = new System.Media.SoundPlayer(Properties.Resources.ขึ้น);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.SMLSHEEP);
            System.Media.SoundPlayer playerdown = new System.Media.SoundPlayer(Properties.Resources.ล่วง);
            System.Media.SoundPlayer player1win = new System.Media.SoundPlayer(Properties.Resources.Winner);
            foreach (PictureBox picBox in this.Controls.OfType<PictureBox>())
            {
                this.Controls.Find("a" + (a + 1).ToString(), false).ElementAt(0).Visible = false;
                pix1.Visible = false;
                button1.Enabled = false;
                button2.Enabled = true;
            }
            a = a + randomNumber;
            if (a==10)
            {
                a = 4;
                a5.Visible = true;
                pix2.Visible = true;
                playerdown.Play();
                
            }
            else if (a == 15)
            {
                a = 31;
                a32.Visible = true;
                pix2.Visible = true;
                playerup.Play();
            }
            else if (a == 42)
            {
                a = 27;
                a28.Visible = true;
                pix2.Visible = true;
                playerdown.Play();
            }
            else if (a == 47)
            {
                a = 35;
                a36.Visible = true;
                pix2.Visible = true;
                playerdown.Play();
            }
            else
            {
                if (a <= 47)
                {
                    this.Controls.Find("a" + (a + 1).ToString(), false).ElementAt(0).Visible = true;
                    pix2.Visible = true;
                    player.Play();
                }
                else 
                {
                    
                    player1win.Play();
                    pictureBox1.Visible = true;
                    a = 1;
                    b = 1;
                    this.button3.Visible = true;
                    this.button5.Visible = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            randomNumber = s;

            System.Media.SoundPlayer player2win = new System.Media.SoundPlayer(Properties.Resources.Winner);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.SMLSHEEP);
            System.Media.SoundPlayer playerdown = new System.Media.SoundPlayer(Properties.Resources.ล่วง);
            System.Media.SoundPlayer playerup = new System.Media.SoundPlayer(Properties.Resources.ขึ้น);
            
            foreach (PictureBox picBox in this.Controls.OfType<PictureBox>())
            {
                this.Controls.Find("b" + (b + 1).ToString(), false).ElementAt(0).Visible = false;
                pix2.Visible = false;
                button2.Enabled = false;
                button1.Enabled = true;
            }
            b = b + randomNumber;
            if (b == 10)
            {
                b = 4;
                b5.Visible = true;
                pix1.Visible = true;
                playerdown.Play();
            }
            else if (b == 15)
            {
                b = 31;
                b32.Visible = true;
                pix1.Visible = true;
                
                playerup.Play();
            }
            else if (b == 42)
            {
                b = 27;
                b28.Visible = true;
                pix1.Visible = true;
                playerdown.Play();
            }
            else if (b == 47)
            {
                b = 35;
                b36.Visible = true;
                pix1.Visible = true;
                playerdown.Play();
            }
            else
            {
                if (b <= 47)
                {
                    this.Controls.Find("b" + (b + 1).ToString(), false).ElementAt(0).Visible = true;
                    pix1.Visible = true;
                    player.Play();
                }
                else
                {
                    pictureBox1.Visible = true;
                    
                    player2win.Play();

                    b = 1;
                    a = 1;
                    this.button3.Visible = true;
                    this.button5.Visible = true;


                        
                }
                
            }
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
            System.Media.SoundPlayer roll = new System.Media.SoundPlayer(Properties.Resources.ลูกเต๋า);
            RollDice();
            roll.Play();
            button4.Enabled = false;

        }

       public void RollDice() 
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rand.Next(1, 6 + 1);

                label_dice.Image = diceimage[dice[0]];
                 s = dice[i];
                
            }
        }

       private void button3_Click(object sender, EventArgs e)
       {

        
        s = 0;
        pictureBox1.Visible = false;
        button3.Visible = false;
        pix2.Visible = false;
        pix1.Visible = false;
        button1.Enabled = true;
        button2.Enabled = true;
        button5.Visible = false;

        for (a = 1; a <= 47; a++)
        {

            this.Controls.Find("a" + (a + 1).ToString(), false).ElementAt(0).Visible = false;
            
        }

        for (b = 1; b <= 47; b++)
        {

            this.Controls.Find("b" + (b + 1).ToString(), false).ElementAt(0).Visible = false;
            

        }
        a = 0;
        b = 0;
        
       }

       private void button5_Click(object sender, EventArgs e)
       {
           this.Close();
       }
    }
}
