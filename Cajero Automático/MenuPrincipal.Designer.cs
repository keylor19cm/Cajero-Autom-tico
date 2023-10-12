namespace Cajero_Automático
{
    partial class MenuPrincipal
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbltitulo3 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.PictureBox();
            this.gbdeposi = new System.Windows.Forms.GroupBox();
            this.gbretiro = new System.Windows.Forms.GroupBox();
            this.btndeposi = new System.Windows.Forms.Button();
            this.btnreti = new System.Windows.Forms.Button();
            this.txtdeposi = new System.Windows.Forms.TextBox();
            this.txtretiro = new System.Windows.Forms.TextBox();
            this.btnsal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).BeginInit();
            this.gbdeposi.SuspendLayout();
            this.gbretiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Cajero_Automático.Properties.Resources._14_141369_windows_mejores_fondos_de_pantalla;
            this.pictureBox2.Image = global::Cajero_Automático.Properties.Resources.Captura_de_pantalla;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lbltitulo3
            // 
            this.lbltitulo3.AutoSize = true;
            this.lbltitulo3.Font = new System.Drawing.Font("Ebrima", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo3.ForeColor = System.Drawing.SystemColors.Info;
            this.lbltitulo3.Image = global::Cajero_Automático.Properties.Resources._14_141369_windows_mejores_fondos_de_pantalla;
            this.lbltitulo3.Location = new System.Drawing.Point(249, 66);
            this.lbltitulo3.Name = "lbltitulo3";
            this.lbltitulo3.Size = new System.Drawing.Size(235, 62);
            this.lbltitulo3.TabIndex = 1;
            this.lbltitulo3.Text = "Por favor seleccione \r\nSu transacción.\r\n";
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::Cajero_Automático.Properties.Resources._14_141369_windows_mejores_fondos_de_pantalla1;
            this.btnsalir.Location = new System.Drawing.Point(-2, -3);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(750, 531);
            this.btnsalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsalir.TabIndex = 0;
            this.btnsalir.TabStop = false;
            // 
            // gbdeposi
            // 
            this.gbdeposi.BackgroundImage = global::Cajero_Automático.Properties.Resources._14_141369_windows_mejores_fondos_de_pantalla;
            this.gbdeposi.Controls.Add(this.txtdeposi);
            this.gbdeposi.Controls.Add(this.btndeposi);
            this.gbdeposi.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbdeposi.ForeColor = System.Drawing.SystemColors.Info;
            this.gbdeposi.Location = new System.Drawing.Point(76, 168);
            this.gbdeposi.Name = "gbdeposi";
            this.gbdeposi.Size = new System.Drawing.Size(572, 113);
            this.gbdeposi.TabIndex = 3;
            this.gbdeposi.TabStop = false;
            this.gbdeposi.Text = "Depositos";
            // 
            // gbretiro
            // 
            this.gbretiro.BackgroundImage = global::Cajero_Automático.Properties.Resources._14_141369_windows_mejores_fondos_de_pantalla;
            this.gbretiro.Controls.Add(this.txtretiro);
            this.gbretiro.Controls.Add(this.btnreti);
            this.gbretiro.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbretiro.ForeColor = System.Drawing.SystemColors.Info;
            this.gbretiro.Location = new System.Drawing.Point(76, 340);
            this.gbretiro.Name = "gbretiro";
            this.gbretiro.Size = new System.Drawing.Size(572, 113);
            this.gbretiro.TabIndex = 4;
            this.gbretiro.TabStop = false;
            this.gbretiro.Text = "Retiros";
            // 
            // btndeposi
            // 
            this.btndeposi.BackColor = System.Drawing.Color.SlateBlue;
            this.btndeposi.Location = new System.Drawing.Point(425, 48);
            this.btndeposi.Name = "btndeposi";
            this.btndeposi.Size = new System.Drawing.Size(121, 47);
            this.btndeposi.TabIndex = 0;
            this.btndeposi.Text = "Depositos";
            this.btndeposi.UseVisualStyleBackColor = false;
            this.btndeposi.Click += new System.EventHandler(this.btndeposi_Click);
            // 
            // btnreti
            // 
            this.btnreti.BackColor = System.Drawing.Color.SlateBlue;
            this.btnreti.Location = new System.Drawing.Point(425, 41);
            this.btnreti.Name = "btnreti";
            this.btnreti.Size = new System.Drawing.Size(121, 47);
            this.btnreti.TabIndex = 1;
            this.btnreti.Text = "Retiros";
            this.btnreti.UseVisualStyleBackColor = false;
            this.btnreti.Click += new System.EventHandler(this.btnreti_Click);
            // 
            // txtdeposi
            // 
            this.txtdeposi.BackColor = System.Drawing.SystemColors.Info;
            this.txtdeposi.Location = new System.Drawing.Point(45, 54);
            this.txtdeposi.Multiline = true;
            this.txtdeposi.Name = "txtdeposi";
            this.txtdeposi.Size = new System.Drawing.Size(157, 41);
            this.txtdeposi.TabIndex = 1;
            // 
            // txtretiro
            // 
            this.txtretiro.BackColor = System.Drawing.SystemColors.Info;
            this.txtretiro.Location = new System.Drawing.Point(45, 41);
            this.txtretiro.Multiline = true;
            this.txtretiro.Name = "txtretiro";
            this.txtretiro.Size = new System.Drawing.Size(157, 41);
            this.txtretiro.TabIndex = 2;
            // 
            // btnsal
            // 
            this.btnsal.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsal.ForeColor = System.Drawing.Color.Firebrick;
            this.btnsal.Image = global::Cajero_Automático.Properties.Resources._14_141369_windows_mejores_fondos_de_pantalla;
            this.btnsal.Location = new System.Drawing.Point(615, 467);
            this.btnsal.Name = "btnsal";
            this.btnsal.Size = new System.Drawing.Size(117, 47);
            this.btnsal.TabIndex = 5;
            this.btnsal.Text = "Salir";
            this.btnsal.UseVisualStyleBackColor = true;
            this.btnsal.Click += new System.EventHandler(this.btnsal_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 526);
            this.Controls.Add(this.btnsal);
            this.Controls.Add(this.gbretiro);
            this.Controls.Add(this.gbdeposi);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbltitulo3);
            this.Controls.Add(this.btnsalir);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsalir)).EndInit();
            this.gbdeposi.ResumeLayout(false);
            this.gbdeposi.PerformLayout();
            this.gbretiro.ResumeLayout(false);
            this.gbretiro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnsalir;
        private System.Windows.Forms.Label lbltitulo3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gbdeposi;
        private System.Windows.Forms.GroupBox gbretiro;
        private System.Windows.Forms.Button btndeposi;
        private System.Windows.Forms.Button btnreti;
        private System.Windows.Forms.TextBox txtdeposi;
        private System.Windows.Forms.TextBox txtretiro;
        private System.Windows.Forms.Button btnsal;
    }
}