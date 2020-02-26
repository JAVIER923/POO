namespace RECIBO_DE_LUZ
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
            this.CMBLUZ = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTKW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PAGAR = new System.Windows.Forms.Label();
            this.TXTPAGAR = new System.Windows.Forms.TextBox();
            this.COBRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMBLUZ
            // 
            this.CMBLUZ.FormattingEnabled = true;
            this.CMBLUZ.Items.AddRange(new object[] {
            "CASA",
            "NEGOCIO"});
            this.CMBLUZ.Location = new System.Drawing.Point(151, 27);
            this.CMBLUZ.Name = "CMBLUZ";
            this.CMBLUZ.Size = new System.Drawing.Size(121, 21);
            this.CMBLUZ.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LUGAR";
            // 
            // TXTKW
            // 
            this.TXTKW.Location = new System.Drawing.Point(139, 72);
            this.TXTKW.Name = "TXTKW";
            this.TXTKW.Size = new System.Drawing.Size(100, 20);
            this.TXTKW.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "KW";
            // 
            // PAGAR
            // 
            this.PAGAR.AutoSize = true;
            this.PAGAR.Location = new System.Drawing.Point(28, 140);
            this.PAGAR.Name = "PAGAR";
            this.PAGAR.Size = new System.Drawing.Size(36, 13);
            this.PAGAR.TabIndex = 4;
            this.PAGAR.Text = "precio";
            // 
            // TXTPAGAR
            // 
            this.TXTPAGAR.Location = new System.Drawing.Point(139, 132);
            this.TXTPAGAR.Name = "TXTPAGAR";
            this.TXTPAGAR.Size = new System.Drawing.Size(100, 20);
            this.TXTPAGAR.TabIndex = 5;
            // 
            // COBRAR
            // 
            this.COBRAR.Location = new System.Drawing.Point(171, 210);
            this.COBRAR.Name = "COBRAR";
            this.COBRAR.Size = new System.Drawing.Size(75, 23);
            this.COBRAR.TabIndex = 6;
            this.COBRAR.Text = "COBRAR";
            this.COBRAR.UseVisualStyleBackColor = true;
            this.COBRAR.Click += new System.EventHandler(this.COBRAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.COBRAR);
            this.Controls.Add(this.TXTPAGAR);
            this.Controls.Add(this.PAGAR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTKW);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CMBLUZ);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBLUZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTKW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PAGAR;
        private System.Windows.Forms.TextBox TXTPAGAR;
        private System.Windows.Forms.Button COBRAR;
    }
}

