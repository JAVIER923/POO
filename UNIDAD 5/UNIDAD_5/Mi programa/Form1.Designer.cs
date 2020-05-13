namespace Mi_programa
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.REGISTRAR = new System.Windows.Forms.Button();
            this.txtNUM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTPREC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTDISP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BUSCAR = new System.Windows.Forms.Button();
            this.TXTBUS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.REGISTRAR);
            this.groupBox1.Controls.Add(this.txtNUM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Refaccionaria";
            // 
            // REGISTRAR
            // 
            this.REGISTRAR.Location = new System.Drawing.Point(226, 98);
            this.REGISTRAR.Name = "REGISTRAR";
            this.REGISTRAR.Size = new System.Drawing.Size(75, 23);
            this.REGISTRAR.TabIndex = 2;
            this.REGISTRAR.Text = "REGISTRAR";
            this.REGISTRAR.UseVisualStyleBackColor = true;
            this.REGISTRAR.Click += new System.EventHandler(this.REGISTRAR_Click);
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(132, 46);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(100, 20);
            this.txtNUM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuantos productos:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTPREC);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TXTDISP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.BUSCAR);
            this.groupBox2.Controls.Add(this.TXTBUS);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(13, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PRODUCTOS";
            // 
            // TXTPREC
            // 
            this.TXTPREC.Location = new System.Drawing.Point(98, 130);
            this.TXTPREC.Name = "TXTPREC";
            this.TXTPREC.Size = new System.Drawing.Size(100, 20);
            this.TXTPREC.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "PRECIO";
            // 
            // TXTDISP
            // 
            this.TXTDISP.Location = new System.Drawing.Point(98, 165);
            this.TXTDISP.Name = "TXTDISP";
            this.TXTDISP.Size = new System.Drawing.Size(100, 20);
            this.TXTDISP.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DISPONIBLES";
            // 
            // BUSCAR
            // 
            this.BUSCAR.Location = new System.Drawing.Point(226, 72);
            this.BUSCAR.Name = "BUSCAR";
            this.BUSCAR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BUSCAR.Size = new System.Drawing.Size(75, 23);
            this.BUSCAR.TabIndex = 2;
            this.BUSCAR.Text = "BUSCAR";
            this.BUSCAR.UseVisualStyleBackColor = true;
            this.BUSCAR.Click += new System.EventHandler(this.BUSCAR_Click);
            // 
            // TXTBUS
            // 
            this.TXTBUS.Location = new System.Drawing.Point(132, 32);
            this.TXTBUS.Name = "TXTBUS";
            this.TXTBUS.Size = new System.Drawing.Size(100, 20);
            this.TXTBUS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "REFACCION";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtcant);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(361, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 142);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "vender";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "vender";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(132, 46);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cuantos productos:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 412);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button REGISTRAR;
        private System.Windows.Forms.TextBox txtNUM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TXTPREC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTDISP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BUSCAR;
        private System.Windows.Forms.TextBox TXTBUS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label5;
    }
}

