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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPatente = new System.Windows.Forms.Label();
            this.rbtmNueva = new System.Windows.Forms.RadioButton();
            this.rbtmVieja = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btmCargar
            // 
            this.btmCargar.Location = new System.Drawing.Point(157, 52);
            this.btmCargar.Name = "btmCargar";
            this.btmCargar.Size = new System.Drawing.Size(80, 23);
            this.btmCargar.TabIndex = 0;
            this.btmCargar.Text = "Cargar";
            this.btmCargar.UseVisualStyleBackColor = true;
            this.btmCargar.Click += new System.EventHandler(this.btmCargar_Click);
            // 
            // mtxtPatente
            // 
            this.mtxtPatente.Location = new System.Drawing.Point(148, 22);
            this.mtxtPatente.Name = "mtxtPatente";
            this.mtxtPatente.Size = new System.Drawing.Size(100, 20);
            this.mtxtPatente.TabIndex = 2;
            this.mtxtPatente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxtPatente_MaskInputRejected);
            this.mtxtPatente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtPatente_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(306, 177);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.lblPatente);
            this.tabPage1.Controls.Add(this.btmCargar);
            this.tabPage1.Controls.Add(this.mtxtPatente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(298, 151);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Patentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtmNueva);
            this.groupBox1.Controls.Add(this.rbtmVieja);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(116, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de Patentes";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(8, 105);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(0, 13);
            this.lblPatente.TabIndex = 5;
            // 
            // rbtmNueva
            // 
            this.rbtmNueva.AutoSize = true;
            this.rbtmNueva.Location = new System.Drawing.Point(7, 19);
            this.rbtmNueva.Name = "rbtmNueva";
            this.rbtmNueva.Size = new System.Drawing.Size(57, 17);
            this.rbtmNueva.TabIndex = 4;
            this.rbtmNueva.TabStop = true;
            this.rbtmNueva.Text = "Nueva";
            this.rbtmNueva.UseVisualStyleBackColor = true;
            this.rbtmNueva.CheckedChanged += new System.EventHandler(this.rbtmNueva_CheckedChanged);
            // 
            // rbtmVieja
            // 
            this.rbtmVieja.AutoSize = true;
            this.rbtmVieja.Location = new System.Drawing.Point(7, 42);
            this.rbtmVieja.Name = "rbtmVieja";
            this.rbtmVieja.Size = new System.Drawing.Size(48, 17);
            this.rbtmVieja.TabIndex = 3;
            this.rbtmVieja.TabStop = true;
            this.rbtmVieja.Text = "Vieja";
            this.rbtmVieja.UseVisualStyleBackColor = true;
            this.rbtmVieja.CheckedChanged += new System.EventHandler(this.rbtmVieja_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CUIT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 191);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btmCargar;
        private System.Windows.Forms.MaskedTextBox mtxtPatente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rbtmNueva;
        private System.Windows.Forms.RadioButton rbtmVieja;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

