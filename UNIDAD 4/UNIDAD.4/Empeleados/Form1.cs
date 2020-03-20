using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empeleados
{
    public partial class Form1 : Form
    {
        Mesero objmesero = new Mesero();
        Repartidor objrepartidor = new Repartidor();
        Cajero objcajero = new Cajero();
            
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNMESERO_Click(object sender, EventArgs e)
        {
          
        
        }

        private void BTNMESERO_Click_1(object sender, EventArgs e)
        {
            switch (cmbemple .Text)
            {
                case "MESERO":
                    {
            objmesero.MESERO1 = Convert.ToString(cmbemple.Text);
            objmesero.CALCULAR  =Convert.ToInt32 (TXTSUELDO.Text);           
            objmesero.DIAS  = Convert .ToInt32 (txtdias .Text);
            objmesero.propina  = Convert .ToInt32 (txtpropina.Text);
            txtsalario.Text  = objmesero.CALCULAR  .ToString();
           MessageBox.Show("EL SUELDO DE" + TXTNOMBRE + "ES DE " + txtsalario);
                        break;

                    }

                case "REPARTIDOR":
                    {
                        objrepartidor.SUELDOO1  = Convert .ToInt32 (TXTSUELDO.Text);
                        objrepartidor.DIAS = Convert.ToInt32(txtdias.Text);
                        objrepartidor.ZONAS = double.Parse(CMBZONA.Text);
                        objrepartidor.ABONO = Convert.ToInt32(txtpropina.Text);
                        objrepartidor.SUELDO2();

                        break;
                    }
             

            }
        

        }
    }
}
