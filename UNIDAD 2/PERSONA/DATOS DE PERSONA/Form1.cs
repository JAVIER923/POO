using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DATOS_DE_PERSONA
{
    public partial class Form1 : Form
    {
        CLASSPERSONA objpersona = new CLASSPERSONA();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNINFOR_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2  ();
            form2 .Show();
        }

        private void BTNREGIS_Click(object sender, EventArgs e)
        {
            objpersona .(DTPNACIMIENTO .Value .Year,DTPNACIMIENTO.Value .Month ,DTPNACIMIENTO .Value.Day,)
            
        }
    }
}
