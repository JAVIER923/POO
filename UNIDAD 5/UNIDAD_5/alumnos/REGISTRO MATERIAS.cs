using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alumnos
{
    public partial class REGISTRO_MATERIAS : Form
    {
        public REGISTRO_MATERIAS()
        {
            InitializeComponent();
        }
        public string[,] MMATERIAS;
        public int cantMATERIAS;
        private int index;

        private void GUARDAR_Click(object sender, EventArgs e)
        {


            //Entrada de Datos

            cantMATERIAS = Convert.ToInt32(TXTREGISA.Text);
            //Inicializamos la matriz
            MMATERIAS = new string[cantMATERIAS, 7];
            //Para ingresar datos a la matriz
            for (int i = 0; i < cantMATERIAS; i++)
            {
                MMATERIAS[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre completo ");
                MMATERIAS[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("ESPAÑOL" + "    INTRODUCE SI O NO    ");
                MMATERIAS[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("MATEMATICAS" + "  INTRODUCE SI O NO   ");
                MMATERIAS[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("HISTORIA" + "   INTRODUCE SI O NO   ");
                MMATERIAS[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("LECTURA" + "    INTRODUCE SI O NO    ");
                MMATERIAS[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("CONTABILIDAD" + "   INTRODUCE SI O NO    ");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Declaración de variables
            string alumno;
            //Entrada de Datos
            alumno = TXTBUSCAR.Text;
            //Filtramos el plato en la matriz

            for (int i = 0; i < cantMATERIAS; i++)
            {
                if (MMATERIAS[i, 0].Equals(alumno))
                {

                    txtnombre.Text = MMATERIAS[i, 0];
                    TXTESPA.Text = MMATERIAS[i, 1];
                    TXTMAT.Text = MMATERIAS[i, 2];
                    TXTHISTORIA.Text = MMATERIAS[i, 3];
                    TXTLECTURA.Text = MMATERIAS[i, 4];
                    TXTCONT.Text = MMATERIAS[i, 5];
                    index = i;
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}