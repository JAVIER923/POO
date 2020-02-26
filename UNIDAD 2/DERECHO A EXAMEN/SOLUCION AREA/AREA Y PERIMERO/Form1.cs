using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AREA_Y_PERIMERO
{
    public partial class Form1 : Form
    {
        CUADRADO objarea = new CUADRADO();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCONT_Click(object sender, EventArgs e)
        {
            objarea.num = int.Parse(TXTINTRO.Text.ToString());
            objarea.calcular();
            TXTARE.Text = objarea.area.ToString();
            TXTPER.Text = objarea.perimetro.ToString();
        }
    }
}
