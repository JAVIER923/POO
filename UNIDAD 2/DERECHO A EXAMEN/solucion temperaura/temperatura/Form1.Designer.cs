namespace temperatura
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
            this.CMBCONV = new System.Windows.Forms.ComboBox();
            this.tipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTGRA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTF = new System.Windows.Forms.TextBox();
            this.CAL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CMBCONV
            // 
            this.CMBCONV.FormattingEnabled = true;
            this.CMBCONV.Items.AddRange(new object[] {
            "centigrados",
            "fahrenheit"});
            this.CMBCONV.Location = new System.Drawing.Point(122, 22);
            this.CMBCONV.Name = "CMBCONV";
            this.CMBCONV.Size = new System.Drawing.Size(121, 21);
            this.CMBCONV.TabIndex = 0;
            // 
            // tipo
            // 
            this.tipo.AutoSize = true;
            this.tipo.Location = new System.Drawing.Point(23, 30);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(32, 13);
            this.tipo.TabIndex = 1;
            this.tipo.Text = "TIPO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRADOS";
            // 
            // TXTGRA
            // 
            this.TXTGRA.Location = new System.Drawing.Point(122, 73);
            this.TXTGRA.Name = "TXTGRA";
            this.TXTGRA.Size = new System.Drawing.Size(100, 20);
            this.TXTGRA.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "FAHRENHEIT";
            // 
            // TXTF
            // 
            this.TXTF.Location = new System.Drawing.Point(122, 116);
            this.TXTF.Name = "TXTF";
            this.TXTF.Size = new System.Drawing.Size(100, 20);
            this.TXTF.TabIndex = 5;
            // 
            // CAL
            // 
            this.CAL.Location = new System.Drawing.Point(173, 223);
            this.CAL.Name = "CAL";
            this.CAL.Size = new System.Drawing.Size(75, 23);
            this.CAL.TabIndex = 6;
            this.CAL.Text = "CALCULAR";
            this.CAL.UseVisualStyleBackColor = true;
            this.CAL.Click += new System.EventHandler(this.CAL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CENTIGRADOS";
            // 
            // TXTG
            // 
            this.TXTG.Location = new System.Drawing.Point(122, 157);
            this.TXTG.Name = "TXTG";
            this.TXTG.Size = new System.Drawing.Size(100, 20);
            this.TXTG.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TXTG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CAL);
            this.Controls.Add(this.TXTF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTGRA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.CMBCONV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBCONV;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTGRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTF;
        private System.Windows.Forms.Button CAL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTG;
    }
}

