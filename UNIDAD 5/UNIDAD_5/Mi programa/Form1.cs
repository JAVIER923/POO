using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mi_programa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[,] MREFAC;
        private int canREF;
        private string IDIOMA;
        private int index;

        private void REGISTRAR_Click(object sender, EventArgs e)
        {
            canREF = Convert.ToInt32(txtNUM.Text);
            //Inicializamos la matriz
            MREFAC  = new string[canREF , 3];
            //Para ingresar datos a la matriz
            for (int i = 0; i < canREF; i++)
            {
                MREFAC[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre del producto" + (i + 1));
                MREFAC[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese cuantos hay " + (i + 1));
                MREFAC[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese costo del producto" + (i + 1));
            }
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {

            //Declaración de variables
            string refac;
            //Entrada de Datos
            refac  = TXTBUS .Text;
            //Filtramos el plato en la matriz

            for (int i = 0; i < canREF ; i++)
            {
                if (MREFAC [i, 0].Equals(refac ))
                {
                 
                    TXTPREC .Text = MREFAC [i, 2];
                    TXTDISP .Text = MREFAC [i, 1];
                 
             


                    index = i;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            int cant, stock;
            //Entrada de Datos
            cant = Convert.ToInt32(txtcant .Text);
            stock = Convert.ToInt32(TXTDISP .Text);

            if (cant <= stock)
            {
                //Disminuimos el stock de ese plato
                MREFAC [index, 2] = Convert.ToString(stock - cant);
            }
            else
            {
                MessageBox.Show("No hay Suficiente producto", "Restaurant", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
