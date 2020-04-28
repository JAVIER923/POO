using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAIS_DEL_MUNDO_E1
{
    public partial class Form1 : Form
    {
        ArrayList paises = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
     

        }

        private void tsb_Click(object sender, EventArgs e)
        {
            if (txtpais.Text == "")
            {
                errorProvider1.SetError(txtpais, "debe ingresar un pais");
                txtpais.Focus();
                return;
            }
            errorProvider1.SetError(txtpais, "");

            Decimal habitante;

            if (!Decimal.TryParse ( txthabit .Text, out habitante))
            {
                errorProvider1.SetError(txthabit , "debe ingresar numero de habitantes");
                txthabit .Focus();
                return;
            }
            errorProvider1.SetError(txthabit , "");

            if (txtidioma  .Text == "")
            {
                errorProvider1.SetError(txtidioma , "debe ingresar un idioma");
               txtidioma  .Focus();
                return;
            }
            errorProvider1.SetError(txtidioma, "");

            if (txtcolor1 .Text == "")
            {
                errorProvider1.SetError(txtcolor1 , "debe ingresar un pais");
                txtcolor1 .Focus();
                return;
            }

            errorProvider1.SetError(txtcolor1, "");


            errorProvider1.SetError(txtcolor1 , "");

            Pais lospaises = new Pais();
            lospaises.pais = txtpais.Text;
            lospaises.idioma  = txtidioma .Text;
            lospaises.color1 = txtcolor1.Text;
            lospaises.color2 = txtcolor2.Text;
            lospaises.color3 = txtcolor3.Text;
            lospaises.habitantes = habitante ;

            paises.Add(lospaises);

            dgv.DataSource = null;
            dgv.DataSource = paises ;

            txtpais.Clear();
            txthabit .Clear();
            txtidioma.Clear();
            txtcolor1 .Clear();
            txtcolor2 .Clear();
            txtcolor3.Clear();
            txtpais.Focus();

        }

    }
}
