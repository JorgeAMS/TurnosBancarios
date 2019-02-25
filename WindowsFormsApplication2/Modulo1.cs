using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Model;

namespace WindowsFormsApplication2
{
    public partial class Modulo1 : Form
    {
        public Modulo1()
        {
            InitializeComponent();
        }
        private void Updateturn(Turno turnmodel)
        {
            using (BankTEntities db = new BankTEntities())
            {
                db.Entry(turnmodel).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        private Turno Cliente(string m)
        {
            try
            {
                using (BankTEntities db = new BankTEntities())
                {
                    var getNextTurn = db.Turnoes.Where(x => x.Estado == "En Espera" && x.Tipo == "C").First();
                    getNextTurn.Modulo = m;
                    getNextTurn.Estado = "Atencion";
                    getNextTurn.FechaAt = DateTime.Now;
                    Updateturn(getNextTurn);
                    return getNextTurn;
                }
            }
            catch
            {
                return null;
            }
        }
        private Turno NoCliente(string m)
        {
            try
            {
                using (BankTEntities db = new BankTEntities())
                {
                    var getNextTurn = db.Turnoes.Where(x => x.Estado == "En Espera" && x.Tipo == "U").First();
                    getNextTurn.Modulo = m;
                    getNextTurn.Estado = "Atencion";
                    getNextTurn.FechaAt = DateTime.Now;
                    Updateturn(getNextTurn);
                    return getNextTurn;
                }
            }
            catch
            {
                return null;
            }
        }
        private Turno Preferencial(string m)
        {
            try
            {
                using (BankTEntities db = new BankTEntities())
                {
                    var getNextTurn = db.Turnoes.Where(x => x.Estado == "En Espera" && x.Tipo == "P").First();
                    getNextTurn.Modulo = m;
                    getNextTurn.Estado = "Atencion";
                    getNextTurn.FechaAt = DateTime.Now;
                    Updateturn(getNextTurn);
                    return getNextTurn;
                }
            }
            catch
            {
                return null;
            }
        }
        private Turno Asesor(string m)
        {
            try
            {
                using (BankTEntities db = new BankTEntities())
                {
                    var getNextTurn = db.Turnoes.Where(x => x.Estado == "En Espera" && x.Tipo == "A").First();
                    getNextTurn.Modulo = m;
                    getNextTurn.Estado = "Atencion";
                    getNextTurn.FechaAt = DateTime.Now;
                    Updateturn(getNextTurn);
                    return getNextTurn;
                }
            }
            catch
            {
                return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Turno t=Cliente("1");
            if (t != null)
            {
                label5.Visible = true;
                label8.Visible = true;
                label5.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label8.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label5.Visible = true;
                label8.Visible = false;
                label5.Text = "No hay turnos de este tipo";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Turno t = Cliente("2");
            if (t != null)
            {
                label6.Visible = true;
                label9.Visible = true;
                label6.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label9.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label6.Visible = true;
                label9.Visible = false;
                label6.Text = "No hay turnos de este tipo";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Turno t = Cliente("3");
            if (t != null)
            {
                label7.Visible = true;
                label10.Visible = true;
                label7.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label10.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label7.Visible = true;
                label10.Visible = false;
                label7.Text = "No hay turnos de este tipo";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turno t = NoCliente("1");
            if (t != null)
            {
                label5.Visible = true;
                label8.Visible = true;
                label5.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label8.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label5.Visible = true;
                label8.Visible = false;
                label5.Text = "No hay turnos de este tipo";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Turno t = NoCliente("2");
            if (t != null)
            {
                label6.Visible = true;
                label9.Visible = true;
                label6.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label9.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label6.Visible = true;
                label9.Visible = false;
                label6.Text = "No hay turnos de este tipo";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Turno t = NoCliente("3");
            if (t != null)
            {
                label7.Visible = true;
                label10.Visible = true;
                label7.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label10.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label7.Visible = true;
                label10.Visible = false;
                label7.Text = "No hay turnos de este tipo";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Turno t = Preferencial("1");
            if (t != null)
            {
                label5.Visible = true;
                label8.Visible = true;
                label5.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label8.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label5.Visible = true;
                label8.Visible = false;
                label5.Text = "No hay turnos de este tipo";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Turno t = Preferencial("2");
            if (t != null)
            {
                label6.Visible = true;
                label9.Visible = true;
                label6.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label9.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label6.Visible = true;
                label9.Visible = false;
                label6.Text = "No hay turnos de este tipo";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Turno t = Preferencial("3");
            if (t != null)
            {
                label7.Visible = true;
                label10.Visible = true;
                label7.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label10.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label7.Visible = true;
                label10.Visible = false;
                label7.Text = "No hay turnos de este tipo";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Turno t = Asesor("11");
            if (t != null)
            {
                label14.Visible = true;
                label16.Visible = true;
                label14.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label16.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label14.Visible = true;
                label16.Visible = false;
                label14.Text = "No hay turnos de este tipo";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Turno t = Asesor("12");
            if (t != null)
            {
                label15.Visible = true;
                label17.Visible = true;
                label15.Text = "Siguiente turno: " + t.Tipo + t.Numero;
                label17.Text = "ID Cliente: " + t.IDCliente;
                FormM.vt.UpdateScreenAfter();
            }
            else
            {
                label15.Visible = true;
                label17.Visible = false;
                label15.Text = "No hay turnos de este tipo";
            }
        }
    }
}
