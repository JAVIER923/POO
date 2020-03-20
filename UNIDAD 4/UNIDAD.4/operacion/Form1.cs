using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operacion
{
    public partial class Form1 : Form
    {
        DIVISION objdivi = new DIVISION();
        MULTIPLICACION objmult = new MULTIPLICACION();
        RESTA objresta = new RESTA();
        SUMA objsuma = new SUMA();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNCAL_Click(object sender, EventArgs e)
        {

            objdivi.Valor1 = float .Parse (TXTNUM1.Text);
            objdivi.Valor2 = float .Parse (TXTNUM2.Text);
            objdivi.Division();
            TXTDIV.Text = objdivi.Resultado.ToString();


            objmult.Valor1 = float .Parse (TXTNUM1.Text);
            objmult.Valor2 = float .Parse (TXTNUM2.Text);
            objmult.Multiplicacion();
            TXTMUL.Text = objmult.Resultado .ToString();


            objresta.Valor1 =float .Parse  (TXTNUM1.Text);
            objresta.Valor2 = float .Parse (TXTNUM2.Text);    
            objresta.Resta();
            TXTREST.Text = objresta.Resultado .ToString();


            objsuma.Valor1 = float .Parse  (TXTNUM1.Text);
            objsuma.Valor2 = float .Parse  (TXTNUM2.Text);
            objsuma.Suma();
            TXTSUMA.Text = objsuma.Resultado .ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
