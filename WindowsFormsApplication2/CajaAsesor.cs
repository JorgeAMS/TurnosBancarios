using System;
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
    public partial class CajaAsesor : Form
    {
        public CajaAsesor()
        {
            InitializeComponent();
            ErrorText.Visible = false;

            int HG = Screen.PrimaryScreen.Bounds.Height;
            int WD = Screen.PrimaryScreen.Bounds.Width;


            bttn_Caja.Location = new Point(((WD / 2) - 292), ((HG / 2) + 5));
            bttn_Asesor.Location = new Point(((WD / 2) + 10), ((HG / 2) + 5));
            textBox1.Location = new Point(((WD / 2) - 105), ((HG / 2) - 110));
            comboBox1.Location = new Point(((WD / 2) - 195), ((HG / 2) - 110));
            ErrorText.Location = new Point(((WD / 2) - 212), ((HG / 2)- 57));


            textBox1.Width = 300;
            comboBox1.Width = 80;
        }

        private void bttn_Caja_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ErrorText.Visible = false;
                textBox1.Text = "";

            }
            else
            {
                ErrorText.Visible = true;
            }
        }

        private void bttn_Asesor_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ErrorText.Visible = false;
                textBox1.Text = "";
                Form1 JM = new Form1();
                JM.Show();
                
            }
            else
            {
                ErrorText.Visible = true;
            }
        }
    }
}
