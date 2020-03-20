using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_y_Perimetro
{
    public partial class Form1 : Form
    {
        claseCuadrado objcalcular = new claseCuadrado();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objcalcular.num1 = int.Parse(txtcal.Text.ToString());
            objcalcular.CALCULAR();
            txtarea.Text = objcalcular.AREA.ToString();
            txtper.Text = objcalcular.PERIMETRO.ToString();             
        }
    }
}
