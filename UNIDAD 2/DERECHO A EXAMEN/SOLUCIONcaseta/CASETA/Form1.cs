using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASETA
{
    public partial class Form1 : Form
    {
        CLASE_VEHICULO OBJVEHICULO = new CLASE_VEHICULO();
        public Form1()
        {
            InitializeComponent();
        }

        private void PRE_Click(object sender, EventArgs e)
        {
            OBJVEHICULO.VEHICULO = CMBVEHICU.Text.ToString();
            OBJVEHICULO.PRECIOS();
            TXTPRE.Text =OBJVEHICULO.PRECIO .ToString ();


        }
    }
}
