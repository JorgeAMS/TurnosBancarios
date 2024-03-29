﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Model;

namespace WindowsFormsApplication2
{
    public partial class VerTurnos : Form
    {
        public int running = 1;
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

            int tamanoLetra = (int)((WD * HG) / 34000);

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

            int TurnoX = WD - TurnoWD - ModuloWD - separadorX - separadorX;
            int TurnoY = (int)(separadorY);
            int ModuloX = WD - ModuloWD - separadorX;
            int ModuloY = (int)(separadorY);

            bttn_Turno.Location = new Point(TurnoX, TurnoY);
            bttn_Modulo.Location = new Point(ModuloX, ModuloY);

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

            bttn_Turno.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra + 1, FontStyle.Bold);
            bttn_Modulo.Font = new Font(bttn_Turno.Font.FontFamily, tamanoLetra + 1, FontStyle.Bold);

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


            int PictureBoxWD = (int)(WD * 0.58);
            int PictureBoxHG = (int)(HG * 0.85);
            pictureBox1.Width = PictureBoxWD;
            pictureBox1.Height = PictureBoxHG;
            pictureBox1.Location = new Point(0 + (int)(WD * 0.02), 0 + (int)(HG * 0.035));
            Texts.Add(bttn_T1);
            Texts.Add(bttn_T2);
            Texts.Add(bttn_T3);
            Texts.Add(bttn_T4);
            Texts.Add(bttn_T5);
            Texts.Add(bttn_T6);
            Modules.Add(bttn_M1);
            Modules.Add(bttn_M2);
            Modules.Add(bttn_M3);
            Modules.Add(bttn_M4);
            Modules.Add(bttn_M5);
            Modules.Add(bttn_M6);
        }

        /*private void VerTurnos_Activated(object sender, EventArgs e)
        {
        }*/
        private void VerTurnos_Load(object sender, EventArgs e)
        {
            UpdateScreen();
            ThreadStart JM = new ThreadStart(imagenesCambiantes);
            Thread hilo = new Thread(JM);
            hilo.Start();
            if (running != 1)
            {
                hilo.Interrupt();
            }
        }

        private void imagenesCambiantes()
        {
            while (running == 1)
            {
                CambiarImagen1();
                CambiarImagen2();
                CambiarImagen3();
            }
        }

        private void CambiarImagen1()
        {
            pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.img1));
            Thread.Sleep(2000);
        }
        private void CambiarImagen2()
        {
            pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.img2));
            Thread.Sleep(2000);
        }
        private void CambiarImagen3()
        {
            pictureBox1.Image = ((System.Drawing.Image)(Properties.Resources.img3));
            Thread.Sleep(2000);
        }

        private void VerTurnos_FormClosing(object sender, FormClosingEventArgs e)
        {
            running = 3;
        }
        
        List<Button> Texts = new List<Button>();
        List<Button> Modules = new List<Button>();        
        public void UpdateScreen()
        {
            using (BankTEntities db = new BankTEntities())
            {
                List<Turno> Turns = new List<Turno>();
                var getTurns = db.Turnoes.Where(x => x.Estado == "Atencion").OrderByDescending(x => x.FechaAt);
                foreach (var t in getTurns)
                {                    
                    Turns.Add(t);                    
                }                
                for(int i = 0; i<Turns.Count && i<6; i++)
                {
                    Texts.ElementAt(i).Text = Turns.ElementAt(i).Tipo+Turns.ElementAt(i).Numero;
                    Texts.ElementAt(i).Visible = true;
                    Modules.ElementAt(i).Text = Turns.ElementAt(i).Modulo;
                    Modules.ElementAt(i).Visible = true;
                }
            }           
        }
        public void UpdateScreenAfter()
        {
            using (BankTEntities db = new BankTEntities())
            {
                List<Turno> Turns = new List<Turno>();
                var getTurns = db.Turnoes.Where(x => x.Estado == "Atencion").OrderByDescending(x => x.FechaAt);
                foreach (var t in getTurns)
                {
                    Turns.Add(t);
                }
                for (int i = 0; i < Turns.Count && i < 6; i++)
                {
                    Texts.ElementAt(i).Text = Turns.ElementAt(i).Tipo + Turns.ElementAt(i).Numero;
                    Texts.ElementAt(i).Visible = true;
                    Modules.ElementAt(i).Text = Turns.ElementAt(i).Modulo;
                    Modules.ElementAt(i).Visible = true;
                }
            }
            bttn_M1.ForeColor = Color.Red;
            bttn_T1.ForeColor = Color.Red;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bttn_M1.ForeColor = Color.Black;
            bttn_T1.ForeColor = Color.Black;
            timer1.Enabled = false;
        }
    }
}
