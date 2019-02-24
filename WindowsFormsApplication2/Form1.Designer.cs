namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttn_Cliente = new System.Windows.Forms.Button();
            this.bttn_NoCliente = new System.Windows.Forms.Button();
            this.bttn_Preferencial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttn_Cliente
            // 
            this.bttn_Cliente.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Cliente.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.Cliente5;
            this.bttn_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttn_Cliente.FlatAppearance.BorderSize = 0;
            this.bttn_Cliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_Cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Cliente.Location = new System.Drawing.Point(530, 0);
            this.bttn_Cliente.Name = "bttn_Cliente";
            this.bttn_Cliente.Size = new System.Drawing.Size(243, 500);
            this.bttn_Cliente.TabIndex = 0;
            this.bttn_Cliente.UseVisualStyleBackColor = false;
            this.bttn_Cliente.Click += new System.EventHandler(this.bttn_Cliente_Click);
            this.bttn_Cliente.MouseLeave += new System.EventHandler(this.bttn_Cliente_MouseLeave);
            this.bttn_Cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttn_Cliente_MouseMove);
            // 
            // bttn_NoCliente
            // 
            this.bttn_NoCliente.BackColor = System.Drawing.Color.Transparent;
            this.bttn_NoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_NoCliente.BackgroundImage")));
            this.bttn_NoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttn_NoCliente.FlatAppearance.BorderSize = 0;
            this.bttn_NoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_NoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_NoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_NoCliente.Location = new System.Drawing.Point(-1, 0);
            this.bttn_NoCliente.Name = "bttn_NoCliente";
            this.bttn_NoCliente.Size = new System.Drawing.Size(499, 232);
            this.bttn_NoCliente.TabIndex = 1;
            this.bttn_NoCliente.UseVisualStyleBackColor = false;
            this.bttn_NoCliente.Click += new System.EventHandler(this.bttn_NoCliente_Click);
            this.bttn_NoCliente.MouseLeave += new System.EventHandler(this.bttn_NoCliente_MouseLeave);
            this.bttn_NoCliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttn_NoCliente_MouseMove);
            // 
            // bttn_Preferencial
            // 
            this.bttn_Preferencial.BackColor = System.Drawing.Color.Transparent;
            this.bttn_Preferencial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_Preferencial.BackgroundImage")));
            this.bttn_Preferencial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttn_Preferencial.FlatAppearance.BorderSize = 0;
            this.bttn_Preferencial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bttn_Preferencial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bttn_Preferencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_Preferencial.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.bttn_Preferencial.Location = new System.Drawing.Point(-1, 263);
            this.bttn_Preferencial.Name = "bttn_Preferencial";
            this.bttn_Preferencial.Size = new System.Drawing.Size(499, 232);
            this.bttn_Preferencial.TabIndex = 2;
            this.bttn_Preferencial.UseVisualStyleBackColor = false;
            this.bttn_Preferencial.Click += new System.EventHandler(this.bttn_Preferencial_Click);
            this.bttn_Preferencial.MouseLeave += new System.EventHandler(this.bttn_Preferencial_MouseLeave);
            this.bttn_Preferencial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bttn_Preferencial_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1161, 643);
            this.Controls.Add(this.bttn_NoCliente);
            this.Controls.Add(this.bttn_Cliente);
            this.Controls.Add(this.bttn_Preferencial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Turnos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_Cliente;
        private System.Windows.Forms.Button bttn_NoCliente;
        private System.Windows.Forms.Button bttn_Preferencial;
    }
}

