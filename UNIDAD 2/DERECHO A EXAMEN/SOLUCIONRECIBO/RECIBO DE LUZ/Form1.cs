using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RECIBO_DE_LUZ
{
    public partial class Form1 : Form
    {
        CLASE_RECIBO objrecibo = new CLASE_RECIBO();

        public Form1()
        {
            InitializeComponent();
        }

        private void COBRAR_Click(object sender, EventArgs e)
        {
            objrecibo.LUGAR = CMBLUZ.Text.ToString();
            objrecibo.KW = int.Parse(TXTKW.Text.ToString());
            objrecibo.LUZ();
            TXTPAGAR.Text = objrecibo.DIN.ToString();
                

        }
    }
}
