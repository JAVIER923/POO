using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entradas
{
    public partial class Form1 : Form
    {
        CLASE_ENTRADA objpersona = new CLASE_ENTRADA();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNCONT_Click(object sender, EventArgs e)
        {
            if (personas.Text == "")
            {
                errorProvider1.SetError(personas, "seleccione assistente");
                personas.Focus();
              return;
             
            }
                if(ENTRADAS .Text == "")
            {
                errorProvider2.SetError(ENTRADAS, "seleccione assistente");
                ENTRADAS.Focus();
                return;


            }
              


            
            objpersona.persona = Convert.ToString(personas.Text);
            objpersona.num1 = Convert.ToInt32(ENTRADAS.Text);
            objpersona.inventario();
            personas.Text="";
            ENTRADAS .Text = "";
            MessageBox.Show("ENTRADA CAPTURADA");       
        }

        private void BTNREPOR_Click(object sender, EventArgs e)
        {
            TXTBEBE.Text = objpersona.bebes .ToString();
            TXTNIÑOS.Text =objpersona .niños .ToString ();
            TXTADULTO.Text = objpersona.adultos .ToString();
            TXTTERCERAEDAD.Text = objpersona.terceraedad .ToString();
        }
    }
}
