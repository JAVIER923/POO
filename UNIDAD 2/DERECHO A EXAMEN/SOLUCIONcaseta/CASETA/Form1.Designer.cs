﻿namespace CASETA
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
            this.CMBVEHICU = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTPRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PRE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMBVEHICU
            // 
            this.CMBVEHICU.FormattingEnabled = true;
            this.CMBVEHICU.Items.AddRange(new object[] {
            "MOTOCICLISTA",
            "AUTOMOVIL",
            "AUTOBUS",
            "TRAILER"});
            this.CMBVEHICU.Location = new System.Drawing.Point(151, 34);
            this.CMBVEHICU.Name = "CMBVEHICU";
            this.CMBVEHICU.Size = new System.Drawing.Size(121, 21);
            this.CMBVEHICU.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "vehiculo";
            // 
            // TXTPRE
            // 
            this.TXTPRE.Location = new System.Drawing.Point(151, 112);
            this.TXTPRE.Name = "TXTPRE";
            this.TXTPRE.Size = new System.Drawing.Size(100, 20);
            this.TXTPRE.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRECIO";
            // 
            // PRE
            // 
            this.PRE.Location = new System.Drawing.Point(183, 216);
            this.PRE.Name = "PRE";
            this.PRE.Size = new System.Drawing.Size(75, 23);
            this.PRE.TabIndex = 4;
            this.PRE.Text = "PRECIO";
            this.PRE.UseVisualStyleBackColor = true;
            this.PRE.Click += new System.EventHandler(this.PRE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTPRE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBVEHICU);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBVEHICU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTPRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PRE;
    }
}

