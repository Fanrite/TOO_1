﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOO_1
{
    public partial class F : Form
    {
        public F()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Щось це не схоже на ООП");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Знову Ctrl + c  Ctrl + v");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ДА");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("УУУУУУУУУУ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Треба щось придумати");
        }
    }
}
