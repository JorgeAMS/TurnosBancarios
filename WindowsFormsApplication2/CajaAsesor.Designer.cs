namespace WindowsFormsApplication2
{
    partial class CajaAsesor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CajaAsesor));
            this.bttn_Caja = new System.Windows.Forms.Button();
            this.bttn_Asesor = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ErrorText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bttn_Caja
            // 
            this.bttn_Caja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Caja.BackgroundImage")));
            this.bttn_Caja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttn_Caja.FlatAppearance.BorderSize = 0;
            this.bttn_Caja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_Caja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Caja.Location = new System.Drawing.Point(85, 276);
            this.bttn_Caja.Name = "bttn_Caja";
            this.bttn_Caja.Size = new System.Drawing.Size(282, 114);
            this.bttn_Caja.TabIndex = 0;
            this.bttn_Caja.UseVisualStyleBackColor = true;
            this.bttn_Caja.Click += new System.EventHandler(this.bttn_Caja_Click);
            // 
            // bttn_Asesor
            // 
            this.bttn_Asesor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Asesor.BackgroundImage")));
            this.bttn_Asesor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttn_Asesor.FlatAppearance.BorderSize = 0;
            this.bttn_Asesor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_Asesor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_Asesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Asesor.Location = new System.Drawing.Point(373, 276);
            this.bttn_Asesor.Name = "bttn_Asesor";
            this.bttn_Asesor.Size = new System.Drawing.Size(282, 115);
            this.bttn_Asesor.TabIndex = 1;
            this.bttn_Asesor.UseVisualStyleBackColor = true;
            this.bttn_Asesor.Click += new System.EventHandler(this.bttn_Asesor_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(304, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 48);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CC",
            "TI",
            "PP",
            "CE"});
            this.comboBox1.Location = new System.Drawing.Point(217, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 48);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "CC";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(182, 241);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(424, 22);
            this.ErrorText.TabIndex = 4;
            this.ErrorText.Text = "ⓘ  Ingrese su documento de identificación por favor.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 5;
            this.label1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CajaAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 494);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bttn_Asesor);
            this.Controls.Add(this.bttn_Caja);
            this.Name = "CajaAsesor";
            this.Text = "CajaAsesor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CajaAsesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_Caja;
        private System.Windows.Forms.Button bttn_Asesor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}