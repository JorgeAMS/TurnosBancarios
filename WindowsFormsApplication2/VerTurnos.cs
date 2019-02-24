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
    public partial class VerTurnos : Form
    {
        public VerTurnos()
        {
            InitializeComponent();
            int HG = Screen.PrimaryScreen.Bounds.Height;
            int WD = Screen.PrimaryScreen.Bounds.Width;

            int TurnoWD = (int)(WD * 0.20);
            int TurnoHG = (int)(HG * 0.11);
            int ModuloWD = (int)(WD * 0.14);
            int ModuloHG = (int)(HG * 0.11);

            int separadorX = (int)(WD * 0.02);
            int separadorY = (int)(HG * 0.02);

            int tamanoLetra = (int)((WD * HG)/34000);

            bttn_Turno.Width = TurnoWD;
            bttn_Turno.Height = TurnoHG;

            bttn_Modulo.Width = ModuloWD;
            bttn_Modulo.Height = ModuloHG;

            bttn_T1.Width = TurnoWD;
            bttn_T1.Height = TurnoHG;
            bttn_T2.Width = TurnoWD;
            bttn_T2.Height = TurnoHG;
            bttn_T3.Width = TurnoWD;
            bttn_T3.Height = TurnoHG;
            bttn_T4.Width = TurnoWD;
            bttn_T4.Height = TurnoHG;
            bttn_T5.Width = TurnoWD;
            bttn_T5.Height = TurnoHG;
            bttn_T6.Width = TurnoWD;
            bttn_T6.Height = TurnoHG;

            bttn_M1.Width = ModuloWD;
            bttn_M1.Height = ModuloHG;
            bttn_M2.Width = ModuloWD;
            bttn_M2.Height = ModuloHG;
            bttn_M3.Width = ModuloWD;
            bttn_M3.Height = ModuloHG;
            bttn_M4.Width = ModuloWD;
            bttn_M4.Height = ModuloHG;
            bttn_M5.Width = ModuloWD;
            bttn_M5.Height = ModuloHG;
            bttn_M6.Width = ModuloWD;
            bttn_M6.Height = ModuloHG;

            int TurnoX = WD-TurnoWD-ModuloWD-separadorX-separadorX;
            int TurnoY = (int)(separadorY);
            int ModuloX = WD - ModuloWD - separadorX;
            int ModuloY = (int)(separadorY);

            bttn_Turno.Location = new Point(TurnoX,TurnoY);
            bttn_Modulo.Location = new Point(ModuloX,ModuloY);

            bttn_T1.Location = new Point(TurnoX, TurnoY + bttn_Turno.Height + bttn_Turno.Location.Y);
            bttn_T2.Location = new Point(TurnoX, TurnoY + bttn_Turno.Height + bttn_T1.Location.Y);
            bttn_T3.Location = new Point(TurnoX, TurnoY + bttn_Turno.Height + bttn_T2.Location.Y);
            bttn_T4.Location = new Point(TurnoX, TurnoY + bttn_Turno.Height + bttn_T3.Location.Y);
            bttn_T5.Location = new Point(TurnoX, TurnoY + bttn_Turno.Height + bttn_T4.Location.Y);
            bttn_T6.Location = new Point(TurnoX, TurnoY + bttn_Turno.Height + bttn_T5.Location.Y);

            bttn_M1.Location = new Point(ModuloX, ModuloY + bttn_Modulo.Height + bttn_Modulo.Location.Y);
            bttn_M2.Location = new Point(ModuloX, ModuloY + bttn_Modulo.Height + bttn_M1.Location.Y);
            bttn_M3.Location = new Point(ModuloX, ModuloY + bttn_Modulo.Height + bttn_M2.Location.Y);
            bttn_M4.Location = new Point(ModuloX, ModuloY + bttn_Modulo.Height + bttn_M3.Location.Y);
            bttn_M5.Location = new Point(ModuloX, ModuloY + bttn_Modulo.Height + bttn_M4.Location.Y);
            bttn_M6.Location = new Point(ModuloX, ModuloY + bttn_Modulo.Height + bttn_M5.Location.Y);

            bttn_Turno.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra+1, FontStyle.Bold);
            bttn_Modulo.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra+1, FontStyle.Bold);

            bttn_T1.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_T2.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_T3.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_T4.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_T5.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_T6.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);

            bttn_M1.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_M2.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_M3.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_M4.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_M5.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);
            bttn_M6.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra);

            bttn_T1.Visible = false;
            bttn_T2.Visible = false;
            bttn_T3.Visible = false;
            bttn_T4.Visible = false;
            bttn_T5.Visible = false;
            bttn_T6.Visible = false;

            bttn_M1.Visible = false;
            bttn_M2.Visible = false;
            bttn_M3.Visible = false;
            bttn_M4.Visible = false;
            bttn_M5.Visible = false;
            bttn_M6.Visible = false;
        }
        
    }
}
