namespace operacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTNUM1 = new System.Windows.Forms.TextBox();
            this.TXTNUM2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTSUMA = new System.Windows.Forms.TextBox();
            this.TXTREST = new System.Windows.Forms.TextBox();
            this.TXTMUL = new System.Windows.Forms.TextBox();
            this.TXTDIV = new System.Windows.Forms.TextBox();
            this.BTNCAL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(136, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTRODUCE UN NUMERO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(136, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INTRODUCE UN NUMERO:";
            // 
            // TXTNUM1
            // 
            this.TXTNUM1.Location = new System.Drawing.Point(296, 58);
            this.TXTNUM1.Name = "TXTNUM1";
            this.TXTNUM1.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM1.TabIndex = 2;
            // 
            // TXTNUM2
            // 
            this.TXTNUM2.Location = new System.Drawing.Point(296, 113);
            this.TXTNUM2.Name = "TXTNUM2";
            this.TXTNUM2.Size = new System.Drawing.Size(100, 20);
            this.TXTNUM2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SUMA:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(37, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "RESTA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MULTIPLICACION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(43, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "DIVISION:";
            // 
            // TXTSUMA
            // 
            this.TXTSUMA.Location = new System.Drawing.Point(186, 203);
            this.TXTSUMA.Name = "TXTSUMA";
            this.TXTSUMA.Size = new System.Drawing.Size(100, 20);
            this.TXTSUMA.TabIndex = 8;
            // 
            // TXTREST
            // 
            this.TXTREST.Location = new System.Drawing.Point(186, 244);
            this.TXTREST.Name = "TXTREST";
            this.TXTREST.Size = new System.Drawing.Size(100, 20);
            this.TXTREST.TabIndex = 9;
            // 
            // TXTMUL
            // 
            this.TXTMUL.Location = new System.Drawing.Point(186, 282);
            this.TXTMUL.Name = "TXTMUL";
            this.TXTMUL.Size = new System.Drawing.Size(100, 20);
            this.TXTMUL.TabIndex = 10;
            // 
            // TXTDIV
            // 
            this.TXTDIV.Location = new System.Drawing.Point(186, 321);
            this.TXTDIV.Name = "TXTDIV";
            this.TXTDIV.Size = new System.Drawing.Size(100, 20);
            this.TXTDIV.TabIndex = 11;
            // 
            // BTNCAL
            // 
            this.BTNCAL.Location = new System.Drawing.Point(447, 365);
            this.BTNCAL.Name = "BTNCAL";
            this.BTNCAL.Size = new System.Drawing.Size(75, 23);
            this.BTNCAL.TabIndex = 12;
            this.BTNCAL.Text = "CALCULAR";
            this.BTNCAL.UseVisualStyleBackColor = true;
            this.BTNCAL.Click += new System.EventHandler(this.BTNCAL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::operacion.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(563, 424);
            this.Controls.Add(this.BTNCAL);
            this.Controls.Add(this.TXTDIV);
            this.Controls.Add(this.TXTMUL);
            this.Controls.Add(this.TXTREST);
            this.Controls.Add(this.TXTSUMA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNUM2);
            this.Controls.Add(this.TXTNUM1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTNUM1;
        private System.Windows.Forms.TextBox TXTNUM2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTSUMA;
        private System.Windows.Forms.TextBox TXTREST;
        private System.Windows.Forms.TextBox TXTMUL;
        private System.Windows.Forms.TextBox TXTDIV;
        private System.Windows.Forms.Button BTNCAL;
    }
}

