using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALIFICACIONES_2._0
{
    public partial class Form1 : Form
    {
        CASS_CALIFICACION objcalificaciones = new CASS_CALIFICACION   ();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            objcalificaciones.califCapturada = int.Parse(txt.Text.ToString());
            objcalificaciones.contaraprobacion ();
            txt.Clear();
        }

        private void btn1rep_Click(object sender, EventArgs e)
        {
            txtapro.Text = objcalificaciones.aprobados.ToString ();
            txtrep.Text = objcalificaciones.reprobados.ToString();
            txtprom.Text = objcalificaciones.promediogrupal1.ToString (); 
        }
    }
}
