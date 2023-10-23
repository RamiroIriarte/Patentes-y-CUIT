namespace Patente
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
            this.btmCargar = new System.Windows.Forms.Button();
            this.mtxtPatente = new System.Windows.Forms.MaskedTextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtmCUIT = new System.Windows.Forms.RadioButton();
            this.rbtmNueva = new System.Windows.Forms.RadioButton();
            this.rbtmVieja = new System.Windows.Forms.RadioButton();
            this.lblPatente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmCargar
            // 
            this.btmCargar.Location = new System.Drawing.Point(207, 71);
            this.btmCargar.Name = "btmCargar";
            this.btmCargar.Size = new System.Drawing.Size(88, 23);
            this.btmCargar.TabIndex = 0;
            this.btmCargar.Text = "Cargar";
            this.btmCargar.UseVisualStyleBackColor = true;
            this.btmCargar.Click += new System.EventHandler(this.btmCargar_Click);
            // 
            // mtxtPatente
            // 
            this.mtxtPatente.Location = new System.Drawing.Point(196, 31);
            this.mtxtPatente.Name = "mtxtPatente";
            this.mtxtPatente.Size = new System.Drawing.Size(108, 20);
            this.mtxtPatente.TabIndex = 2;
            this.mtxtPatente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPatente_MaskInputRejected);
            this.mtxtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPatente_KeyPress);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(16, 152);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(0, 13);
            this.lblCuit.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtmCUIT);
            this.groupBox1.Controls.Add(this.rbtmNueva);
            this.groupBox1.Controls.Add(this.rbtmVieja);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 85);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Que desea cargar?";
            // 
            // rbtmCUIT
            // 
            this.rbtmCUIT.AutoSize = true;
            this.rbtmCUIT.Location = new System.Drawing.Point(7, 65);
            this.rbtmCUIT.Name = "rbtmCUIT";
            this.rbtmCUIT.Size = new System.Drawing.Size(50, 17);
            this.rbtmCUIT.TabIndex = 5;
            this.rbtmCUIT.TabStop = true;
            this.rbtmCUIT.Text = "CUIT";
            this.rbtmCUIT.UseVisualStyleBackColor = true;
            this.rbtmCUIT.CheckedChanged += new System.EventHandler(this.rbtmCUIT_CheckedChanged);
            // 
            // rbtmNueva
            // 
            this.rbtmNueva.AutoSize = true;
            this.rbtmNueva.Location = new System.Drawing.Point(7, 19);
            this.rbtmNueva.Name = "rbtmNueva";
            this.rbtmNueva.Size = new System.Drawing.Size(97, 17);
            this.rbtmNueva.TabIndex = 4;
            this.rbtmNueva.TabStop = true;
            this.rbtmNueva.Text = "Patente Nueva";
            this.rbtmNueva.UseVisualStyleBackColor = true;
            this.rbtmNueva.CheckedChanged += new System.EventHandler(this.rbtmNueva_CheckedChanged);
            // 
            // rbtmVieja
            // 
            this.rbtmVieja.AutoSize = true;
            this.rbtmVieja.Location = new System.Drawing.Point(7, 42);
            this.rbtmVieja.Name = "rbtmVieja";
            this.rbtmVieja.Size = new System.Drawing.Size(88, 17);
            this.rbtmVieja.TabIndex = 3;
            this.rbtmVieja.TabStop = true;
            this.rbtmVieja.Text = "Patente Vieja";
            this.rbtmVieja.UseVisualStyleBackColor = true;
            this.rbtmVieja.CheckedChanged += new System.EventHandler(this.rbtmVieja_CheckedChanged);
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(16, 122);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(0, 13);
            this.lblPatente.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 172);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btmCargar);
            this.Controls.Add(this.mtxtPatente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmCargar;
        private System.Windows.Forms.MaskedTextBox mtxtPatente;
        private System.Windows.Forms.RadioButton rbtmNueva;
        private System.Windows.Forms.RadioButton rbtmVieja;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtmCUIT;
        private System.Windows.Forms.Label lblCuit;
    }
}

