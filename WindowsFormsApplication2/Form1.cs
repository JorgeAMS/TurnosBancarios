using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Model;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int hg = Screen.PrimaryScreen.Bounds.Height;
            int wd = Screen.PrimaryScreen.Bounds.Width;
            
            bttn_Cliente.Location = new Point(((wd/2)+151),((hg/2)-247));
            bttn_NoCliente.Location = new Point(((wd/2)-387),((hg/2)-247));
            bttn_Preferencial.Location = new Point(((wd/2)-387),((hg/2)+15));
            label1.Location = new Point(wd/2,hg/2);
        }
        private void FinRes(Turno t)
        {
            label1.Text = "Su turno es: " + t.Tipo + t.Numero;
            label1.Visible = true;
            bttn_Cliente.Visible = false;
            bttn_NoCliente.Visible = false;
            bttn_Preferencial.Visible = false;
            timer1.Enabled = true;
        }
        private void bttn_Cliente_Click(object sender, EventArgs e)
        {
            using (BankTEntities db = new BankTEntities())
            {
                Turno Turn = new Turno();
                try
                {
                    var getLastTurn = db.Turnoes.Where(x => x.Tipo == "C").OrderByDescending(x => x.ID).First();
                    if (Convert.ToInt32(getLastTurn.Numero) < 99)
                    {
                        Turn.Numero = (Convert.ToInt32(getLastTurn.Numero) + 1).ToString();
                    }
                    else
                    {
                        Turn.Numero = "1";
                    }
                    Turn.Tipo = "C";
                    Turn.Modulo = "0";
                    Turn.IDCliente = "666";
                    Turn.Estado = "En Espera";
                }
                catch
                {
                    Turn.Numero = "1";
                    Turn.Tipo = "C";
                    Turn.Modulo = "0";
                    Turn.IDCliente = "666";
                    Turn.Estado = "En Espera";
                }
                var TurnCreation = db.Set<Turno>();
                TurnCreation.Add(Turn);
                db.SaveChanges();
                FinRes(Turn);
            }                
        }
        private void bttn_NoCliente_Click(object sender, EventArgs e)
        {
            using (BankTEntities db = new BankTEntities())
            {
                Turno Turn = new Turno();
                try
                {
                    var getLastTurn = db.Turnoes.Where(x => x.Tipo == "U").OrderByDescending(x => x.ID).First();
                    if (Convert.ToInt32(getLastTurn.Numero) < 99)
                    {
                        Turn.Numero = (Convert.ToInt32(getLastTurn.Numero) + 1).ToString();
                    }
                    else
                    {
                        Turn.Numero = "1";
                    }
                    Turn.Tipo = "U";
                    Turn.Modulo = "0";
                    Turn.IDCliente = "666";
                    Turn.Estado = "En Espera";
                }
                catch
                {
                    Turn.Numero = "1";
                    Turn.Tipo = "U";
                    Turn.Modulo = "0";
                    Turn.IDCliente = "666";
                    Turn.Estado = "En Espera";
                }
                var TurnCreation = db.Set<Turno>();
                TurnCreation.Add(Turn);
                db.SaveChanges();
                FinRes(Turn);
            }
        }

        private void bttn_Preferencial_Click(object sender, EventArgs e)
        {
            using (BankTEntities db = new BankTEntities())
            {
                Turno Turn = new Turno();
                try
                {
                    var getLastTurn = db.Turnoes.Where(x => x.Tipo == "P").OrderByDescending(x => x.ID).First();
                    if (Convert.ToInt32(getLastTurn.Numero) < 99)
                    {
                        Turn.Numero = (Convert.ToInt32(getLastTurn.Numero) + 1).ToString();
                    }
                    else
                    {
                        Turn.Numero = "1";
                    }
                    Turn.Tipo = "P";
                    Turn.Modulo = "0";
                    Turn.IDCliente = "666";
                    Turn.Estado = "En Espera";
                }
                catch
                {
                    Turn.Numero = "1";
                    Turn.Tipo = "P";
                    Turn.Modulo = "0";
                    Turn.IDCliente = "666";
                    Turn.Estado = "En Espera";
                }
                var TurnCreation = db.Set<Turno>();
                TurnCreation.Add(Turn);
                db.SaveChanges();
                FinRes(Turn);
            }
        }

        private void bttn_Cliente_MouseMove(object sender, MouseEventArgs e)
        {
            bttn_Cliente.Image = ((System.Drawing.Image)(Properties.Resources.ClienteC));
        }

        private void bttn_Cliente_MouseLeave(object sender, EventArgs e)
        {
            bttn_Cliente.Image = ((System.Drawing.Image)(Properties.Resources.Cliente5));
        }

        private void bttn_NoCliente_MouseMove(object sender, MouseEventArgs e)
        {
            bttn_NoCliente.Image = ((System.Drawing.Image)(Properties.Resources.NoClienteC));
        }

        private void bttn_NoCliente_MouseLeave(object sender, EventArgs e)
        {
            bttn_NoCliente.Image = ((System.Drawing.Image)(Properties.Resources.NoCliente));
        }

        private void bttn_Preferencial_MouseMove(object sender, MouseEventArgs e)
        {
            bttn_Preferencial.Image = ((System.Drawing.Image)(Properties.Resources.Prioritaria5C));
        }

        private void bttn_Preferencial_MouseLeave(object sender, EventArgs e)
        {
            bttn_Preferencial.Image = ((System.Drawing.Image)(Properties.Resources.Prioritaria5));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormM.vt.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            timer1.Enabled = false;
            Dispose(false);
        }
    }
}
