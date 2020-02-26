namespace DATOS_DE_PERSONA
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
            this.CMBTIPO = new System.Windows.Forms.ComboBox();
            this.CMBESTADO = new System.Windows.Forms.ComboBox();
            this.DTPNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.LBLNOM = new System.Windows.Forms.Label();
            this.LBLAPELLIDO = new System.Windows.Forms.Label();
            this.TXTNOMBRE = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDO = new System.Windows.Forms.TextBox();
            this.LBLMATERNO = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LBLFECHANAC = new System.Windows.Forms.Label();
            this.TIPOPERSONA = new System.Windows.Forms.Label();
            this.LBLEST = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LBLTELEFONO = new System.Windows.Forms.Label();
            this.BTNINFOR = new System.Windows.Forms.Button();
            this.BTNREGIS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CMBTIPO
            // 
            this.CMBTIPO.FormattingEnabled = true;
            this.CMBTIPO.Items.AddRange(new object[] {
            "ALUMNO",
            "DOCENTE",
            "ADMINISTRATIVO"});
            this.CMBTIPO.Location = new System.Drawing.Point(151, 293);
            this.CMBTIPO.Name = "CMBTIPO";
            this.CMBTIPO.Size = new System.Drawing.Size(121, 21);
            this.CMBTIPO.TabIndex = 0;
            // 
            // CMBESTADO
            // 
            this.CMBESTADO.FormattingEnabled = true;
            this.CMBESTADO.Items.AddRange(new object[] {
            "Aguascalientes",
            "",
            "Baja California",
            "",
            "Baja California Sur",
            "",
            "Campeche",
            "",
            "Chiapas",
            "",
            "Chihuahua",
            "",
            "Coahuila",
            "",
            "Colima",
            "",
            "Distrito Federal",
            "",
            "Durango",
            "",
            "Estado de México",
            "",
            "Guanajuato",
            "",
            "Guerrero",
            "",
            "Hidalgo",
            "",
            "Jalisco",
            "",
            "Michoacán",
            "",
            "Morelos",
            "",
            "Nayarit",
            "",
            "Nuevo León",
            "",
            "Oaxaca",
            "",
            "Puebla",
            "",
            "Querétaro",
            "",
            "Quintana Roo",
            "",
            "San Luis Potosí",
            "",
            "Sinaloa",
            "",
            "Sonora",
            "",
            "Tabasco",
            "",
            "Tamaulipas",
            "",
            "Tlaxcala",
            "",
            "Veracruz",
            "",
            "Yucatán",
            "",
            "Zacatecas"});
            this.CMBESTADO.Location = new System.Drawing.Point(151, 346);
            this.CMBESTADO.Name = "CMBESTADO";
            this.CMBESTADO.Size = new System.Drawing.Size(121, 21);
            this.CMBESTADO.TabIndex = 1;
            // 
            // DTPNACIMIENTO
            // 
            this.DTPNACIMIENTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPNACIMIENTO.Location = new System.Drawing.Point(174, 170);
            this.DTPNACIMIENTO.Name = "DTPNACIMIENTO";
            this.DTPNACIMIENTO.Size = new System.Drawing.Size(69, 20);
            this.DTPNACIMIENTO.TabIndex = 2;
            // 
            // LBLNOM
            // 
            this.LBLNOM.AutoSize = true;
            this.LBLNOM.Location = new System.Drawing.Point(35, 34);
            this.LBLNOM.Name = "LBLNOM";
            this.LBLNOM.Size = new System.Drawing.Size(54, 13);
            this.LBLNOM.TabIndex = 3;
            this.LBLNOM.Text = "NOMBRE";
            // 
            // LBLAPELLIDO
            // 
            this.LBLAPELLIDO.AutoSize = true;
            this.LBLAPELLIDO.Location = new System.Drawing.Point(38, 67);
            this.LBLAPELLIDO.Name = "LBLAPELLIDO";
            this.LBLAPELLIDO.Size = new System.Drawing.Size(114, 13);
            this.LBLAPELLIDO.TabIndex = 4;
            this.LBLAPELLIDO.Text = "APELLIDO PATERNO";
            // 
            // TXTNOMBRE
            // 
            this.TXTNOMBRE.Location = new System.Drawing.Point(172, 26);
            this.TXTNOMBRE.Name = "TXTNOMBRE";
            this.TXTNOMBRE.Size = new System.Drawing.Size(100, 20);
            this.TXTNOMBRE.TabIndex = 5;
            // 
            // TXTAPELLIDO
            // 
            this.TXTAPELLIDO.Location = new System.Drawing.Point(172, 59);
            this.TXTAPELLIDO.Name = "TXTAPELLIDO";
            this.TXTAPELLIDO.Size = new System.Drawing.Size(100, 20);
            this.TXTAPELLIDO.TabIndex = 6;
            // 
            // LBLMATERNO
            // 
            this.LBLMATERNO.AutoSize = true;
            this.LBLMATERNO.Location = new System.Drawing.Point(38, 125);
            this.LBLMATERNO.Name = "LBLMATERNO";
            this.LBLMATERNO.Size = new System.Drawing.Size(110, 13);
            this.LBLMATERNO.TabIndex = 7;
            this.LBLMATERNO.Text = "APELIDO MATERNO";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // LBLFECHANAC
            // 
            this.LBLFECHANAC.AutoSize = true;
            this.LBLFECHANAC.Location = new System.Drawing.Point(38, 177);
            this.LBLFECHANAC.Name = "LBLFECHANAC";
            this.LBLFECHANAC.Size = new System.Drawing.Size(130, 13);
            this.LBLFECHANAC.TabIndex = 9;
            this.LBLFECHANAC.Text = "FECHA DE NACIMIENTO";
            // 
            // TIPOPERSONA
            // 
            this.TIPOPERSONA.AutoSize = true;
            this.TIPOPERSONA.Location = new System.Drawing.Point(38, 301);
            this.TIPOPERSONA.Name = "TIPOPERSONA";
            this.TIPOPERSONA.Size = new System.Drawing.Size(32, 13);
            this.TIPOPERSONA.TabIndex = 10;
            this.TIPOPERSONA.Text = "TIPO";
            // 
            // LBLEST
            // 
            this.LBLEST.AutoSize = true;
            this.LBLEST.Location = new System.Drawing.Point(41, 346);
            this.LBLEST.Name = "LBLEST";
            this.LBLEST.Size = new System.Drawing.Size(54, 13);
            this.LBLEST.TabIndex = 11;
            this.LBLEST.Text = "ESTADO ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(129, 427);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 12;
            // 
            // LBLTELEFONO
            // 
            this.LBLTELEFONO.AutoSize = true;
            this.LBLTELEFONO.Location = new System.Drawing.Point(38, 434);
            this.LBLTELEFONO.Name = "LBLTELEFONO";
            this.LBLTELEFONO.Size = new System.Drawing.Size(64, 13);
            this.LBLTELEFONO.TabIndex = 13;
            this.LBLTELEFONO.Text = "TELEFONO";
            // 
            // BTNINFOR
            // 
            this.BTNINFOR.Location = new System.Drawing.Point(274, 391);
            this.BTNINFOR.Name = "BTNINFOR";
            this.BTNINFOR.Size = new System.Drawing.Size(111, 27);
            this.BTNINFOR.TabIndex = 14;
            this.BTNINFOR.Text = "INFORME";
            this.BTNINFOR.UseVisualStyleBackColor = true;
            this.BTNINFOR.Click += new System.EventHandler(this.BTNINFOR_Click);
            // 
            // BTNREGIS
            // 
            this.BTNREGIS.Location = new System.Drawing.Point(274, 427);
            this.BTNREGIS.Name = "BTNREGIS";
            this.BTNREGIS.Size = new System.Drawing.Size(111, 23);
            this.BTNREGIS.TabIndex = 15;
            this.BTNREGIS.Text = "REGISTRAR";
            this.BTNREGIS.UseVisualStyleBackColor = true;
            this.BTNREGIS.Click += new System.EventHandler(this.BTNREGIS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 469);
            this.Controls.Add(this.BTNREGIS);
            this.Controls.Add(this.BTNINFOR);
            this.Controls.Add(this.LBLTELEFONO);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.LBLEST);
            this.Controls.Add(this.TIPOPERSONA);
            this.Controls.Add(this.LBLFECHANAC);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LBLMATERNO);
            this.Controls.Add(this.TXTAPELLIDO);
            this.Controls.Add(this.TXTNOMBRE);
            this.Controls.Add(this.LBLAPELLIDO);
            this.Controls.Add(this.LBLNOM);
            this.Controls.Add(this.DTPNACIMIENTO);
            this.Controls.Add(this.CMBESTADO);
            this.Controls.Add(this.CMBTIPO);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMBTIPO;
        private System.Windows.Forms.ComboBox CMBESTADO;
        private System.Windows.Forms.DateTimePicker DTPNACIMIENTO;
        private System.Windows.Forms.Label LBLNOM;
        private System.Windows.Forms.Label LBLAPELLIDO;
        private System.Windows.Forms.TextBox TXTNOMBRE;
        private System.Windows.Forms.TextBox TXTAPELLIDO;
        private System.Windows.Forms.Label LBLMATERNO;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LBLFECHANAC;
        private System.Windows.Forms.Label TIPOPERSONA;
        private System.Windows.Forms.Label LBLEST;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label LBLTELEFONO;
        private System.Windows.Forms.Button BTNINFOR;
        private System.Windows.Forms.Button BTNREGIS;
    }
}

