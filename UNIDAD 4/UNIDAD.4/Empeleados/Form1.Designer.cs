namespace Empeleados
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
            this.cmbemple = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpropina = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMBZONA = new System.Windows.Forms.ComboBox();
            this.txtpedido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CMBCAJA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTSUELDO = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BTNMESERO = new System.Windows.Forms.Button();
            this.BTNREPARTIDOR = new System.Windows.Forms.Button();
            this.BTNCAJERO = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.c.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbemple
            // 
            this.cmbemple.FormattingEnabled = true;
            this.cmbemple.Items.AddRange(new object[] {
            "MESERO",
            "CAJERO",
            "REPARTIDOR"});
            this.cmbemple.Location = new System.Drawing.Point(490, 27);
            this.cmbemple.Name = "cmbemple";
            this.cmbemple.Size = new System.Drawing.Size(121, 21);
            this.cmbemple.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLEADO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTNMESERO);
            this.groupBox1.Controls.Add(this.txtpropina);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 124);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MESERO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Propina semanal:";
            // 
            // txtpropina
            // 
            this.txtpropina.Location = new System.Drawing.Point(128, 39);
            this.txtpropina.Name = "txtpropina";
            this.txtpropina.Size = new System.Drawing.Size(100, 20);
            this.txtpropina.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTNREPARTIDOR);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtpedido);
            this.groupBox2.Controls.Add(this.CMBZONA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 167);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "REPARTIDOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Zonas:";
            // 
            // CMBZONA
            // 
            this.CMBZONA.FormattingEnabled = true;
            this.CMBZONA.Items.AddRange(new object[] {
            "ZONA 1",
            "ZONA 2"});
            this.CMBZONA.Location = new System.Drawing.Point(101, 51);
            this.CMBZONA.Name = "CMBZONA";
            this.CMBZONA.Size = new System.Drawing.Size(121, 21);
            this.CMBZONA.TabIndex = 1;
            // 
            // txtpedido
            // 
            this.txtpedido.Location = new System.Drawing.Point(116, 98);
            this.txtpedido.Name = "txtpedido";
            this.txtpedido.Size = new System.Drawing.Size(100, 20);
            this.txtpedido.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pedidos entregados:";
            // 
            // c
            // 
            this.c.Controls.Add(this.BTNCAJERO);
            this.c.Controls.Add(this.CMBCAJA);
            this.c.Controls.Add(this.label8);
            this.c.Location = new System.Drawing.Point(12, 364);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(290, 122);
            this.c.TabIndex = 6;
            this.c.TabStop = false;
            this.c.Text = "CAJERO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "CAJA:";
            // 
            // CMBCAJA
            // 
            this.CMBCAJA.FormattingEnabled = true;
            this.CMBCAJA.Items.AddRange(new object[] {
            "CAJA 1",
            "CAJA 2"});
            this.CMBCAJA.Location = new System.Drawing.Point(147, 31);
            this.CMBCAJA.Name = "CMBCAJA";
            this.CMBCAJA.Size = new System.Drawing.Size(121, 21);
            this.CMBCAJA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SUELDO:";
            // 
            // TXTSUELDO
            // 
            this.TXTSUELDO.Location = new System.Drawing.Point(473, 116);
            this.TXTSUELDO.Name = "TXTSUELDO";
            this.TXTSUELDO.Size = new System.Drawing.Size(100, 20);
            this.TXTSUELDO.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(373, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "DIAS:";
            // 
            // BTNMESERO
            // 
            this.BTNMESERO.Location = new System.Drawing.Point(147, 79);
            this.BTNMESERO.Name = "BTNMESERO";
            this.BTNMESERO.Size = new System.Drawing.Size(75, 23);
            this.BTNMESERO.TabIndex = 10;
            this.BTNMESERO.Text = "SALARIO";
            this.BTNMESERO.UseVisualStyleBackColor = true;
            this.BTNMESERO.Click += new System.EventHandler(this.BTNMESERO_Click_1);
            // 
            // BTNREPARTIDOR
            // 
            this.BTNREPARTIDOR.Location = new System.Drawing.Point(162, 138);
            this.BTNREPARTIDOR.Name = "BTNREPARTIDOR";
            this.BTNREPARTIDOR.Size = new System.Drawing.Size(75, 23);
            this.BTNREPARTIDOR.TabIndex = 6;
            this.BTNREPARTIDOR.Text = "SALARIO";
            this.BTNREPARTIDOR.UseVisualStyleBackColor = true;
            // 
            // BTNCAJERO
            // 
            this.BTNCAJERO.Location = new System.Drawing.Point(162, 77);
            this.BTNCAJERO.Name = "BTNCAJERO";
            this.BTNCAJERO.Size = new System.Drawing.Size(75, 23);
            this.BTNCAJERO.TabIndex = 2;
            this.BTNCAJERO.Text = "SALARIO";
            this.BTNCAJERO.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "NOMBRE:";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(473, 70);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 11;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(473, 166);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(100, 20);
            this.txtdias.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "SALARIO:";
            // 
            // txtsalario
            // 
            this.txtsalario.Location = new System.Drawing.Point(473, 215);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(100, 20);
            this.txtsalario.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 498);
            this.Controls.Add(this.txtdias);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTSUELDO);
            this.Controls.Add(this.c);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbemple);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.c.ResumeLayout(false);
            this.c.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbemple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpropina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CMBZONA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpedido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox c;
        private System.Windows.Forms.ComboBox CMBCAJA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXTSUELDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTNMESERO;
        private System.Windows.Forms.Button BTNREPARTIDOR;
        private System.Windows.Forms.Button BTNCAJERO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsalario;
    }
}

