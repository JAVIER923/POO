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

namespace PAISES_DEL_MUNDO
{
    public partial class Form1 : Form
    {
        ArrayList paises = new ArrayList();
        public Form1()
        {
       
            InitializeComponent();
        }
        //VARIABLES
        private string[,] MPAIS;
        private int cantpais;
        private string IDIOMA;
        private string COLOR1;
        private string COLOR2;
        private string COLOR3;
        private int index;

        private void BTNDAT_Click(object sender, EventArgs e)
        {
            //Entrada de Datos

            cantpais = Convert.ToInt32(TXTNPAISES.Text);
            //Inicializamos la matriz
            MPAIS = new string[cantpais, 6];
            //Para ingresar datos a la matriz
            for (int i = 0; i < cantpais; i++)
            {
                MPAIS[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre del PAIS " + (i + 1));
                MPAIS[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de habitantes " + (i + 1));
                MPAIS[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese idioma del pais " + (i + 1));
                MPAIS[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un color de su bandera " + (i + 1));
                MPAIS[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese otro color de su bandera " + (i + 1));
                MPAIS[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese otro color de su bandera " + (i + 1));
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string pais;
            //Entrada de Datos
            pais = TXTBUSCAR.Text;
            //Filtramos el plato en la matriz

            for (int i = 0; i < cantpais; i++)
            {
                if (MPAIS[i, 0].Equals(pais))
                {
                    txtpais.Text = MPAIS[i, 0];
                    txthabit.Text = MPAIS[i, 1];
                    txtidioma.Text = MPAIS[i, 2];
                    txtcolor1.Text = MPAIS[i, 3];
                    txtcolor2.Text = MPAIS[i, 4];
                    txtcolor3.Text = MPAIS[i, 5];


                    index = i;
                }
            }
        }
    }
}