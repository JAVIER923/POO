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
    public partial class REGISTRO_M : Form
    {
        public REGISTRO_M()
        {
            InitializeComponent();
        }

        public string[,] MMATERIAS;
        public int CANTMATERIAS;
        public string[,] MDOCENTE;
        public int cantDOCENTES;
        private int index;


        private void GUARDAR_Click(object sender, EventArgs e)
        {




            //Entrada de Datos

            cantDOCENTES = Convert.ToInt32(TXTREGISA.Text);
            //Inicializamos la matriz
            MDOCENTE = new string[cantDOCENTES, 7];
            //Para ingresar datos a la matriz
            for (int i = 0; i < cantDOCENTES; i++)
            {
                MDOCENTE[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre completo ");
                MDOCENTE[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese fecha de nacimiento");
                MDOCENTE[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese curp ");
                MDOCENTE[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de telefono");
                MDOCENTE[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese email ");
                MDOCENTE[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Numero de maestro ");
                MDOCENTE[i, 6] = Microsoft.VisualBasic.Interaction.InputBox(" Ingresa Sueldo ");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            REGISTRO_MATERIAS  REGISTRA = new REGISTRO_MATERIAS ();
            REGISTRA.Show();


        }
    }
}
