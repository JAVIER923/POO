namespace entradas
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
            this.personas = new System.Windows.Forms.ComboBox();
            this.LBLASIS = new System.Windows.Forms.Label();
            this.LBLENTRA = new System.Windows.Forms.Label();
            this.ENTRADAS = new System.Windows.Forms.ComboBox();
            this.LBLBEBE = new System.Windows.Forms.Label();
            this.LBLNIÑOS = new System.Windows.Forms.Label();
            this.LBLADUL = new System.Windows.Forms.Label();
            this.LBLTER = new System.Windows.Forms.Label();
            this.TXTBEBE = new System.Windows.Forms.TextBox();
            this.TXTNIÑOS = new System.Windows.Forms.TextBox();
            this.TXTADULTO = new System.Windows.Forms.TextBox();
            this.TXTTERCERAEDAD = new System.Windows.Forms.TextBox();
            this.BTNCONT = new System.Windows.Forms.Button();
            this.BTNREPOR = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // personas
            // 
            this.personas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personas.FormattingEnabled = true;
            this.personas.Items.AddRange(new object[] {
            "BEBES",
            "NIÑOS",
            "ADULTOS",
            "TERCERA EDAD"});
            this.personas.Location = new System.Drawing.Point(220, 21);
            this.personas.Name = "personas";
            this.personas.Size = new System.Drawing.Size(121, 21);
            this.personas.TabIndex = 0;
            // 
            // LBLASIS
            // 
            this.LBLASIS.AutoSize = true;
            this.LBLASIS.Location = new System.Drawing.Point(28, 28);
            this.LBLASIS.Name = "LBLASIS";
            this.LBLASIS.Size = new System.Drawing.Size(67, 13);
            this.LBLASIS.TabIndex = 1;
            this.LBLASIS.Text = "ASISTENTE";
            // 
            // LBLENTRA
            // 
            this.LBLENTRA.AutoSize = true;
            this.LBLENTRA.Location = new System.Drawing.Point(28, 70);
            this.LBLENTRA.Name = "LBLENTRA";
            this.LBLENTRA.Size = new System.Drawing.Size(66, 13);
            this.LBLENTRA.TabIndex = 2;
            this.LBLENTRA.Text = "ENTRADAS";
            // 
            // ENTRADAS
            // 
            this.ENTRADAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ENTRADAS.FormattingEnabled = true;
            this.ENTRADAS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ENTRADAS.Location = new System.Drawing.Point(220, 62);
            this.ENTRADAS.Name = "ENTRADAS";
            this.ENTRADAS.Size = new System.Drawing.Size(121, 21);
            this.ENTRADAS.TabIndex = 3;
            // 
            // LBLBEBE
            // 
            this.LBLBEBE.AutoSize = true;
            this.LBLBEBE.Location = new System.Drawing.Point(28, 183);
            this.LBLBEBE.Name = "LBLBEBE";
            this.LBLBEBE.Size = new System.Drawing.Size(35, 13);
            this.LBLBEBE.TabIndex = 4;
            this.LBLBEBE.Text = "BEBE";
            // 
            // LBLNIÑOS
            // 
            this.LBLNIÑOS.AutoSize = true;
            this.LBLNIÑOS.Location = new System.Drawing.Point(28, 212);
            this.LBLNIÑOS.Name = "LBLNIÑOS";
            this.LBLNIÑOS.Size = new System.Drawing.Size(41, 13);
            this.LBLNIÑOS.TabIndex = 5;
            this.LBLNIÑOS.Text = "NIÑOS";
            // 
            // LBLADUL
            // 
            this.LBLADUL.AutoSize = true;
            this.LBLADUL.Location = new System.Drawing.Point(28, 242);
            this.LBLADUL.Name = "LBLADUL";
            this.LBLADUL.Size = new System.Drawing.Size(58, 13);
            this.LBLADUL.TabIndex = 6;
            this.LBLADUL.Text = "ADULTOS";
            // 
            // LBLTER
            // 
            this.LBLTER.AutoSize = true;
            this.LBLTER.Location = new System.Drawing.Point(28, 272);
            this.LBLTER.Name = "LBLTER";
            this.LBLTER.Size = new System.Drawing.Size(91, 13);
            this.LBLTER.TabIndex = 7;
            this.LBLTER.Text = "TERCERA EDAD";
            // 
            // TXTBEBE
            // 
            this.TXTBEBE.Location = new System.Drawing.Point(163, 175);
            this.TXTBEBE.Name = "TXTBEBE";
            this.TXTBEBE.Size = new System.Drawing.Size(100, 20);
            this.TXTBEBE.TabIndex = 8;
            // 
            // TXTNIÑOS
            // 
            this.TXTNIÑOS.Location = new System.Drawing.Point(163, 205);
            this.TXTNIÑOS.Name = "TXTNIÑOS";
            this.TXTNIÑOS.Size = new System.Drawing.Size(100, 20);
            this.TXTNIÑOS.TabIndex = 9;
            // 
            // TXTADULTO
            // 
            this.TXTADULTO.Location = new System.Drawing.Point(163, 234);
            this.TXTADULTO.Name = "TXTADULTO";
            this.TXTADULTO.Size = new System.Drawing.Size(100, 20);
            this.TXTADULTO.TabIndex = 10;
            // 
            // TXTTERCERAEDAD
            // 
            this.TXTTERCERAEDAD.Location = new System.Drawing.Point(163, 265);
            this.TXTTERCERAEDAD.Name = "TXTTERCERAEDAD";
            this.TXTTERCERAEDAD.Size = new System.Drawing.Size(100, 20);
            this.TXTTERCERAEDAD.TabIndex = 11;
            // 
            // BTNCONT
            // 
            this.BTNCONT.Location = new System.Drawing.Point(272, 124);
            this.BTNCONT.Name = "BTNCONT";
            this.BTNCONT.Size = new System.Drawing.Size(104, 24);
            this.BTNCONT.TabIndex = 12;
            this.BTNCONT.Text = "CONTABILIZAR";
            this.BTNCONT.UseVisualStyleBackColor = true;
            this.BTNCONT.Click += new System.EventHandler(this.BTNCONT_Click);
            // 
            // BTNREPOR
            // 
            this.BTNREPOR.Location = new System.Drawing.Point(272, 317);
            this.BTNREPOR.Name = "BTNREPOR";
            this.BTNREPOR.Size = new System.Drawing.Size(104, 23);
            this.BTNREPOR.TabIndex = 13;
            this.BTNREPOR.Text = "REPORTAR";
            this.BTNREPOR.UseVisualStyleBackColor = true;
            this.BTNREPOR.Click += new System.EventHandler(this.BTNREPOR_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(402, 404);
            this.Controls.Add(this.BTNREPOR);
            this.Controls.Add(this.BTNCONT);
            this.Controls.Add(this.TXTTERCERAEDAD);
            this.Controls.Add(this.TXTADULTO);
            this.Controls.Add(this.TXTNIÑOS);
            this.Controls.Add(this.TXTBEBE);
            this.Controls.Add(this.LBLTER);
            this.Controls.Add(this.LBLADUL);
            this.Controls.Add(this.LBLNIÑOS);
            this.Controls.Add(this.LBLBEBE);
            this.Controls.Add(this.ENTRADAS);
            this.Controls.Add(this.LBLENTRA);
            this.Controls.Add(this.LBLASIS);
            this.Controls.Add(this.personas);
            this.Name = "Form1";
            this.Text = "concierto";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox personas;
        private System.Windows.Forms.Label LBLASIS;
        private System.Windows.Forms.Label LBLENTRA;
        private System.Windows.Forms.ComboBox ENTRADAS;
        private System.Windows.Forms.Label LBLBEBE;
        private System.Windows.Forms.Label LBLNIÑOS;
        private System.Windows.Forms.Label LBLADUL;
        private System.Windows.Forms.Label LBLTER;
        private System.Windows.Forms.TextBox TXTBEBE;
        private System.Windows.Forms.TextBox TXTNIÑOS;
        private System.Windows.Forms.TextBox TXTADULTO;
        private System.Windows.Forms.TextBox TXTTERCERAEDAD;
        private System.Windows.Forms.Button BTNCONT;
        private System.Windows.Forms.Button BTNREPOR;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

