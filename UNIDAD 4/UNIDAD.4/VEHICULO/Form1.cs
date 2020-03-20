using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VEHICULO
{
    public partial class Form1 : Form
    {
        vehiculo objaereo = new vehiculo();
        Aereo objaereos = new Aereo();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnarran_Click(object sender, EventArgs e)
        {
            objaereo.arrancarmotor  = btnarran.Text;
            MessageBox.Show(objaereo.ArrancarMotor () );

        }

        private void btnapag_Click(object sender, EventArgs e)
        {
            objaereo.paramotor = btnapag.Text;
            MessageBox.Show(objaereo.Paramotor());
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            objaereos.estado = btnEstado.Text;
            objaereos.tipoAero = cmbtipo.Text.ToString();
            objaereos.enVuelo();
            MessageBox.Show(objaereos.enVuelo().ToString());

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            objaereo.tipocombustible = txtcom.Text;
            objaereo.color = txtcolor.Text;
            objaereo.numllantas = int.Parse(txtnumllan.Text);
            objaereo.numpuertas = int.Parse(txtpuer.Text);
            objaereo.numventanas = int.Parse(txtvent.Text);
            objaereos.numturbinas = int.Parse(txtturb.Text);
            objaereos.numventanas = int.Parse(txtvent.Text);
            objaereos.tipoAero = cmbtipo.Text;
            MessageBox.Show(" La informacion del objeto " + cmbtipo.Text + " se a guardado ");
        }
    }
}
