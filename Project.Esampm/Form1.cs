﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Esampm
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
          
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            Entrada f = new Entrada();
            label1.Visible = false;
            f.MdiParent = this;
            f.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
