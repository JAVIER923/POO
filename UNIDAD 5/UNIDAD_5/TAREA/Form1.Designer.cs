namespace TAREA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNUEVO = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTAPELLIDO = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTCORREO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DTPFECHANACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTSALARIO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DGVDATOS = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNUEVO});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNUEVO
            // 
            this.tsbNUEVO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("tsbNUEVO.Image")));
            this.tsbNUEVO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNUEVO.Name = "tsbNUEVO";
            this.tsbNUEVO.Size = new System.Drawing.Size(23, 22);
            this.tsbNUEVO.Text = "toolStripButton1";
            this.tsbNUEVO.ToolTipText = "Crear nuevo usuario";
            this.tsbNUEVO.Click += new System.EventHandler(this.tsbNUEVO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // TXTID
            // 
            this.TXTID.Location = new System.Drawing.Point(66, 43);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(100, 20);
            this.TXTID.TabIndex = 2;
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTNOMBRE.Location = new System.Drawing.Point(96, 84);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(167, 20);
            this.TXTNOMBRE.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRE:";
            // 
            // TXTAPELLIDO
            // 
            this.TXTAPELLIDO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTAPELLIDO.Location = new System.Drawing.Point(96, 128);
            this.TXTAPELLIDO.Name = "TXTAPELLIDO";
            this.TXTAPELLIDO.Size = new System.Drawing.Size(283, 20);
            this.TXTAPELLIDO.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "APELLIDOS:";
            // 
            // TXTCORREO
            // 
            this.TXTCORREO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTCORREO.Location = new System.Drawing.Point(96, 171);
            this.TXTCORREO.Name = "TXTCORREO";
            this.TXTCORREO.Size = new System.Drawing.Size(283, 20);
            this.TXTCORREO.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E-MAIL:";
            // 
            // DTPFECHANACIMIENTO
            // 
            this.DTPFECHANACIMIENTO.Location = new System.Drawing.Point(151, 210);
            this.DTPFECHANACIMIENTO.Name = "DTPFECHANACIMIENTO";
            this.DTPFECHANACIMIENTO.Size = new System.Drawing.Size(200, 20);
            this.DTPFECHANACIMIENTO.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "FECHA DE NACIMIENTO:";
            // 
            // TXTSALARIO
            // 
            this.TXTSALARIO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTSALARIO.Location = new System.Drawing.Point(502, 210);
            this.TXTSALARIO.Name = "TXTSALARIO";
            this.TXTSALARIO.Size = new System.Drawing.Size(100, 20);
            this.TXTSALARIO.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "SALARIO:";
            // 
            // DGVDATOS
            // 
            this.DGVDATOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVDATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDATOS.Location = new System.Drawing.Point(12, 251);
            this.DGVDATOS.Name = "DGVDATOS";
            this.DGVDATOS.Size = new System.Drawing.Size(661, 150);
            this.DGVDATOS.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 413);
            this.Controls.Add(this.DGVDATOS);
            this.Controls.Add(this.TXTSALARIO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPFECHANACIMIENTO);
            this.Controls.Add(this.TXTCORREO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTAPELLIDO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "PERSONAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDATOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNUEVO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTAPELLIDO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXTCORREO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DTPFECHANACIMIENTO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTSALARIO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DGVDATOS;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

