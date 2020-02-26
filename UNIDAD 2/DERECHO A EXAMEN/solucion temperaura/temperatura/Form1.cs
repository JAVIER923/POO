using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temperatura
{
    public partial class Form1 : Form
    {
        TEMPERATURA objtemp = new TEMPERATURA();
        public Form1()
        {
            InitializeComponent();
        }

        private void CAL_Click(object sender, EventArgs e)
        {
            objtemp.temperatura  = CMBCONV.Text.ToString();
            objtemp.NUM1 = double.Parse(TXTGRA.Text.ToString());
            objtemp.MODIFICACION();
            TXTF.Text = objtemp.FAHREN.ToString();
            TXTG.Text = objtemp.CENT.ToString();

             
        }
    }
}
