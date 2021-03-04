namespace ProyectoCerealesVentura
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtMini = new System.Windows.Forms.PictureBox();
            this.BtSalir = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btRegis = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btIngreso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lb2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtcontra = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtSalir)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.BtMini);
            this.panel1.Controls.Add(this.BtSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 48);
            this.panel1.TabIndex = 0;
            // 
            // BtMini
            // 
            this.BtMini.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtMini.BackgroundImage = global::ProyectoCerealesVentura.Properties.Resources._354794_200;
            this.BtMini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtMini.Image = global::ProyectoCerealesVentura.Properties.Resources._3a72524a_f9cd_4391_89b4_e1e314b2fe05;
            this.BtMini.Location = new System.Drawing.Point(696, 27);
            this.BtMini.Name = "BtMini";
            this.BtMini.Size = new System.Drawing.Size(34, 21);
            this.BtMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtMini.TabIndex = 1;
            this.BtMini.TabStop = false;
            this.BtMini.Click += new System.EventHandler(this.BtMini_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.BackColor = System.Drawing.SystemColors.Desktop;
            this.BtSalir.BackgroundImage = global::ProyectoCerealesVentura.Properties.Resources._1524600_200;
            this.BtSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtSalir.Image = global::ProyectoCerealesVentura.Properties.Resources._5673377d_3c17_47d5_9b62_cce530ab9fb1;
            this.BtSalir.Location = new System.Drawing.Point(754, 16);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(32, 22);
            this.BtSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtSalir.TabIndex = 0;
            this.BtSalir.TabStop = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BackgroundImage = global::ProyectoCerealesVentura.Properties.Resources.logo_from;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(13, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 419);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel3.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel3.Controls.Add(this.btRegis);
            this.panel3.Controls.Add(this.btIngreso);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lb2);
            this.panel3.Controls.Add(this.lb1);
            this.panel3.Controls.Add(this.txtcontra);
            this.panel3.Location = new System.Drawing.Point(350, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 419);
            this.panel3.TabIndex = 2;
            // 
            // btRegis
            // 
            this.btRegis.ActiveBorderThickness = 1;
            this.btRegis.ActiveCornerRadius = 20;
            this.btRegis.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btRegis.ActiveForecolor = System.Drawing.Color.Black;
            this.btRegis.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btRegis.BackColor = System.Drawing.SystemColors.Desktop;
            this.btRegis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btRegis.BackgroundImage")));
            this.btRegis.ButtonText = "Registrar";
            this.btRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRegis.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegis.ForeColor = System.Drawing.Color.SeaGreen;
            this.btRegis.IdleBorderThickness = 1;
            this.btRegis.IdleCornerRadius = 20;
            this.btRegis.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btRegis.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRegis.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRegis.Location = new System.Drawing.Point(269, 345);
            this.btRegis.Margin = new System.Windows.Forms.Padding(5);
            this.btRegis.Name = "btRegis";
            this.btRegis.Size = new System.Drawing.Size(138, 41);
            this.btRegis.TabIndex = 8;
            this.btRegis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btRegis.Click += new System.EventHandler(this.btRegis_Click);
            // 
            // btIngreso
            // 
            this.btIngreso.ActiveBorderThickness = 1;
            this.btIngreso.ActiveCornerRadius = 20;
            this.btIngreso.ActiveFillColor = System.Drawing.Color.LightSeaGreen;
            this.btIngreso.ActiveForecolor = System.Drawing.Color.Black;
            this.btIngreso.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btIngreso.BackColor = System.Drawing.SystemColors.Desktop;
            this.btIngreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btIngreso.BackgroundImage")));
            this.btIngreso.ButtonText = "Ingresar";
            this.btIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btIngreso.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIngreso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btIngreso.IdleBorderThickness = 1;
            this.btIngreso.IdleCornerRadius = 20;
            this.btIngreso.IdleFillColor = System.Drawing.Color.DarkCyan;
            this.btIngreso.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btIngreso.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btIngreso.Location = new System.Drawing.Point(37, 345);
            this.btIngreso.Margin = new System.Windows.Forms.Padding(5);
            this.btIngreso.Name = "btIngreso";
            this.btIngreso.Size = new System.Drawing.Size(138, 41);
            this.btIngreso.TabIndex = 7;
            this.btIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btIngreso.Click += new System.EventHandler(this.btIngreso_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.BackgroundImage = global::ProyectoCerealesVentura.Properties.Resources._585e4beacb11b227491c33991;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(161, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 127);
            this.panel4.TabIndex = 5;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.Black;
            this.lb2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lb2.Location = new System.Drawing.Point(194, 124);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(87, 32);
            this.lb2.TabIndex = 4;
            this.lb2.Text = "Login";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.Black;
            this.lb1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Snow;
            this.lb1.Location = new System.Drawing.Point(141, 311);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(188, 20);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "¿Olvido su contraseña?";
            // 
            // txtcontra
            // 
            this.txtcontra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcontra.ForeColor = System.Drawing.Color.White;
            this.txtcontra.HintForeColor = System.Drawing.Color.Empty;
            this.txtcontra.HintText = "";
            this.txtcontra.isPassword = false;
            this.txtcontra.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.txtcontra.LineIdleColor = System.Drawing.Color.LightGray;
            this.txtcontra.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtcontra.LineThickness = 3;
            this.txtcontra.Location = new System.Drawing.Point(37, 250);
            this.txtcontra.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontra.Name = "txtcontra";
            this.txtcontra.Size = new System.Drawing.Size(370, 44);
            this.txtcontra.TabIndex = 2;
            this.txtcontra.Tag = "";
            this.txtcontra.Text = "Ingrese su contraseña.";
            this.txtcontra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcontra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtxcontra_KeyPress);
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.DarkCyan;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.LightGray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(37, 187);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(370, 44);
            this.bunifuMaterialTextbox1.TabIndex = 9;
            this.bunifuMaterialTextbox1.Tag = "Ingrese su contraseña.";
            this.bunifuMaterialTextbox1.Text = "ingrese su usuario";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoCerealesVentura.Properties.Resources.fondo_from;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 555);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtSalir)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox BtMini;
        private System.Windows.Forms.PictureBox BtSalir;
        private Bunifu.Framework.UI.BunifuCustomLabel lb2;
        private Bunifu.Framework.UI.BunifuCustomLabel lb1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcontra;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btRegis;
        private Bunifu.Framework.UI.BunifuThinButton2 btIngreso;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
    }
}

