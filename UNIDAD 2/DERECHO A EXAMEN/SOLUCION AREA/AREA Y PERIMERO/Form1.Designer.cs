namespace AREA_Y_PERIMERO
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
            this.LBL1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BTNCONT = new System.Windows.Forms.Button();
            this.TXTPER = new System.Windows.Forms.TextBox();
            this.TXTARE = new System.Windows.Forms.TextBox();
            this.TXTINTRO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(30, 29);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(49, 13);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "MEDIDA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AREA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PERIMETRO";
            // 
            // BTNCONT
            // 
            this.BTNCONT.Location = new System.Drawing.Point(178, 226);
            this.BTNCONT.Name = "BTNCONT";
            this.BTNCONT.Size = new System.Drawing.Size(75, 23);
            this.BTNCONT.TabIndex = 3;
            this.BTNCONT.Text = "CALCULAR";
            this.BTNCONT.UseVisualStyleBackColor = true;
            this.BTNCONT.Click += new System.EventHandler(this.BTNCONT_Click);
            // 
            // TXTPER
            // 
            this.TXTPER.Location = new System.Drawing.Point(144, 181);
            this.TXTPER.Name = "TXTPER";
            this.TXTPER.Size = new System.Drawing.Size(100, 20);
            this.TXTPER.TabIndex = 4;
            // 
            // TXTARE
            // 
            this.TXTARE.Location = new System.Drawing.Point(144, 124);
            this.TXTARE.Name = "TXTARE";
            this.TXTARE.Size = new System.Drawing.Size(100, 20);
            this.TXTARE.TabIndex = 5;
            // 
            // TXTINTRO
            // 
            this.TXTINTRO.Location = new System.Drawing.Point(125, 29);
            this.TXTINTRO.Name = "TXTINTRO";
            this.TXTINTRO.Size = new System.Drawing.Size(100, 20);
            this.TXTINTRO.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TXTINTRO);
            this.Controls.Add(this.TXTARE);
            this.Controls.Add(this.TXTPER);
            this.Controls.Add(this.BTNCONT);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBL1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BTNCONT;
        private System.Windows.Forms.TextBox TXTPER;
        private System.Windows.Forms.TextBox TXTARE;
        private System.Windows.Forms.TextBox TXTINTRO;
    }
}

