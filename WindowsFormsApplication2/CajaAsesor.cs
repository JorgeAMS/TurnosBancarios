using System;
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
            label1.Location = new Point(WD / 2, HG / 2);

            textBox1.Width = 300;
            comboBox1.Width = 80;
        }

        private void bttn_Caja_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Form1 f1 = new Form1(textBox1.Text);
                f1.Show();
                Dispose(false);
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
                using (BankTEntities db = new BankTEntities())
                {
                    Turno Turn = new Turno();
                    try
                    {
                        var getLastTurn = db.Turnoes.Where(x => x.Tipo == "A").OrderByDescending(x => x.ID).First();
                        if (Convert.ToInt32(getLastTurn.Numero) < 99)
                        {
                            Turn.Numero = (Convert.ToInt32(getLastTurn.Numero) + 1).ToString();
                        }
                        else
                        {
                            Turn.Numero = "1";
                        }
                        Turn.Tipo = "A";
                        Turn.Modulo = "0";
                        Turn.IDCliente = textBox1.Text;
                        Turn.Estado = "En Espera";
                    }
                    catch
                    {
                        Turn.Numero = "1";
                        Turn.Tipo = "A";
                        Turn.Modulo = "0";
                        Turn.IDCliente = textBox1.Text;
                        Turn.Estado = "En Espera";
                    }
                    var TurnCreation = db.Set<Turno>();
                    TurnCreation.Add(Turn);
                    db.SaveChanges();
                    FinRes(Turn);
                }

            }
            else
            {
                ErrorText.Visible = true;
            }
        }
        private void FinRes(Turno t)
        {
            label1.Text = "Su turno es: " + t.Tipo + t.Numero;
            label1.Visible = true;
            bttn_Caja.Visible = false;
            bttn_Asesor.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible=false;
            timer1.Enabled = true;
        }
        private void CajaAsesor_Load(object sender, EventArgs e)
        {
            FormM.vt.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CajaAsesor CA = new CajaAsesor();
            CA.Show();
            timer1.Enabled = false;
            Dispose(false);
        }
    }
}
