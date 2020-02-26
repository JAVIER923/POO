namespace CALIFICACIONES_2._0
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
            this.lbl1CAL = new System.Windows.Forms.Label();
            this.LBLAPRO = new System.Windows.Forms.Label();
            this.lbl3repro = new System.Windows.Forms.Label();
            this.btn1rep = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapro = new System.Windows.Forms.TextBox();
            this.txtrep = new System.Windows.Forms.TextBox();
            this.txtprom = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.TextBox();
            this.btn2capt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1CAL
            // 
            this.lbl1CAL.AutoSize = true;
            this.lbl1CAL.Location = new System.Drawing.Point(13, 25);
            this.lbl1CAL.Name = "lbl1CAL";
            this.lbl1CAL.Size = new System.Drawing.Size(75, 13);
            this.lbl1CAL.TabIndex = 0;
            this.lbl1CAL.Text = "Calificaciones:";
            // 
            // LBLAPRO
            // 
            this.LBLAPRO.AutoSize = true;
            this.LBLAPRO.Location = new System.Drawing.Point(23, 159);
            this.LBLAPRO.Name = "LBLAPRO";
            this.LBLAPRO.Size = new System.Drawing.Size(53, 13);
            this.LBLAPRO.TabIndex = 1;
            this.LBLAPRO.Text = "Aprobado";
            // 
            // lbl3repro
            // 
            this.lbl3repro.AutoSize = true;
            this.lbl3repro.Location = new System.Drawing.Point(16, 201);
            this.lbl3repro.Name = "lbl3repro";
            this.lbl3repro.Size = new System.Drawing.Size(60, 13);
            this.lbl3repro.TabIndex = 2;
            this.lbl3repro.Text = "Reprobado";
            // 
            // btn1rep
            // 
            this.btn1rep.BackColor = System.Drawing.Color.MintCream;
            this.btn1rep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn1rep.Location = new System.Drawing.Point(16, 79);
            this.btn1rep.Name = "btn1rep";
            this.btn1rep.Size = new System.Drawing.Size(75, 23);
            this.btn1rep.TabIndex = 3;
            this.btn1rep.Text = "Reportar";
            this.btn1rep.UseVisualStyleBackColor = false;
            this.btn1rep.Click += new System.EventHandler(this.btn1rep_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Promedio General";
            // 
            // txtapro
            // 
            this.txtapro.Location = new System.Drawing.Point(99, 152);
            this.txtapro.Name = "txtapro";
            this.txtapro.Size = new System.Drawing.Size(100, 20);
            this.txtapro.TabIndex = 5;
            // 
            // txtrep
            // 
            this.txtrep.Location = new System.Drawing.Point(99, 194);
            this.txtrep.Name = "txtrep";
            this.txtrep.Size = new System.Drawing.Size(100, 20);
            this.txtrep.TabIndex = 6;
            // 
            // txtprom
            // 
            this.txtprom.Location = new System.Drawing.Point(128, 228);
            this.txtprom.Name = "txtprom";
            this.txtprom.Size = new System.Drawing.Size(100, 20);
            this.txtprom.TabIndex = 7;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(91, 22);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 20);
            this.txt.TabIndex = 8;
            // 
            // btn2capt
            // 
            this.btn2capt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2capt.Location = new System.Drawing.Point(197, 20);
            this.btn2capt.Name = "btn2capt";
            this.btn2capt.Size = new System.Drawing.Size(75, 23);
            this.btn2capt.TabIndex = 9;
            this.btn2capt.Text = "Capturar";
            this.btn2capt.UseVisualStyleBackColor = true;
            this.btn2capt.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn2capt);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtprom);
            this.Controls.Add(this.txtrep);
            this.Controls.Add(this.txtapro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn1rep);
            this.Controls.Add(this.lbl3repro);
            this.Controls.Add(this.LBLAPRO);
            this.Controls.Add(this.lbl1CAL);
            this.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Name = "Form1";
            this.Text = "CALIFICACIONES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1CAL;
        private System.Windows.Forms.Label LBLAPRO;
        private System.Windows.Forms.Label lbl3repro;
        private System.Windows.Forms.Button btn1rep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapro;
        private System.Windows.Forms.TextBox txtrep;
        private System.Windows.Forms.TextBox txtprom;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Button btn2capt;
    }
}

