﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

 

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;
            //pictureBox1.Location = new Point(pictureBox1.Location.X + 61, pictureBox1.Location.Y);
            int[] array2 = new int[49];
            for (int i = 0; i < 49; i++)
            {
                array2[i] = 1;
            }
            array2[0] = 0;
            array2[10] = 10;
            array2[15] = 15;
            array2[42] = 42;
            array2[47] = 47;
            array2[48] = 48;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;


            
            int[] array1 = new int[49];
            for (int i = 0; i < 49; i++)
            {
                array1[i] = 1;
            }
            array1[0] = 0;
            array1[10] = 10;
            array1[15] = 15;
            array1[42] = 42;
            array1[47] = 47;
            array1[48] = 48;



        }

        
    }
}
