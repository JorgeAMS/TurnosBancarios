﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //bttn_NoCliente.BackColor = System.Drawing.Color.Transparent;
            //int hg = this.Height;
            //int wd = this.Width;
            int hg = Screen.PrimaryScreen.Bounds.Height;
            int wd = Screen.PrimaryScreen.Bounds.Width;
            
            bttn_Cliente.Location = new Point(((wd/2)+151),((hg/2)-247));
            bttn_NoCliente.Location = new Point(((wd/2)-387),((hg/2)-247));
            bttn_Preferencial.Location = new Point(((wd/2)-387),((hg/2)+15));
        }

        private void bttn_Cliente_Click(object sender, EventArgs e)
        {

        }
        private void bttn_NoCliente_Click(object sender, EventArgs e)
        {

        }

        private void bttn_Preferencial_Click(object sender, EventArgs e)
        {

        }

        private void bttn_Cliente_MouseMove(object sender, MouseEventArgs e)
        {
            bttn_Cliente.Visible = false;
        }

        private void bttn_Cliente_MouseLeave(object sender, EventArgs e)
        {
            bttn_Cliente.Visible = true;
        }

        private void bttn_NoCliente_MouseMove(object sender, MouseEventArgs e)
        {
            bttn_NoCliente.BackgroundImage = Image.FromFile(@"Assets/NoClienteC.png");
        }

        private void bttn_NoCliente_MouseLeave(object sender, EventArgs e)
        {
            bttn_NoCliente.BackgroundImage = Image.FromFile(@"Assets/NoCliente.png");
        }

        private void bttn_Preferencial_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void bttn_Preferencial_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}