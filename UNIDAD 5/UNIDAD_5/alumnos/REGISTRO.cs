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
    public partial class REGISTRO : Form
    {
        public REGISTRO()
        {
            InitializeComponent();

        }
        public Double PROM;
        public string[,] MALUMNO;
        public int cantREGISTROS;
        private int index;
        public double CAL1;
        public double CAL2;
        public double CAL3;
        public double CAL4;
        public double CAL5;
        private void GUARDAR_Click(object sender, EventArgs e)
        {
           



            //Entrada de Datos

            cantREGISTROS = Convert.ToInt32(TXTREGISA.Text);
            //Inicializamos la matriz
            MALUMNO = new string[cantREGISTROS, 12];
            //Para ingresar datos a la matriz
            for (int i = 0; i < cantREGISTROS; i++)
            {
                MALUMNO[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre completo " );
                MALUMNO[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese fecha de nacimiento" );
                MALUMNO[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese curp " );
                MALUMNO[i, 3] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de telefono" );
                MALUMNO[i, 4] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese email " );
                MALUMNO[i, 5] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese numero de control " );
                MALUMNO[i, 6] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese carrera " );
                MALUMNO[i, 7] = Microsoft.VisualBasic.Interaction.InputBox("calificacion español " );
                MALUMNO[i, 8] = Microsoft.VisualBasic.Interaction.InputBox("Calificacion matematicas " );
                MALUMNO[i, 9] = Microsoft.VisualBasic.Interaction.InputBox("Calificacion historia "  );
                MALUMNO[i, 10] = Microsoft.VisualBasic.Interaction.InputBox("Calificacion español" );
                MALUMNO[i, 11] = Microsoft.VisualBasic.Interaction.InputBox("Calificacion contabilidad " );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declaración de variables
            string alumno;
            //Entrada de Datos
            alumno = TXTBUSCAR.Text;
            //Filtramos el plato en la matriz

            for (int i = 0; i < cantREGISTROS; i++)
            {
                if ( MALUMNO [i, 0].Equals(alumno))
                {

                    txtnombre.Text = MALUMNO[i, 0];
                    TXTESPA.Text = MALUMNO[i, 7];
                    TXTMAT.Text = MALUMNO[i, 8];
                    TXTHISTORIA.Text = MALUMNO[i, 9];
                    TXTLECTURA.Text = MALUMNO[i, 10];
                    TXTCONT.Text = MALUMNO[i, 11];
                     index = i;
                    
                }
                CAL1 = double.Parse(TXTESPA.Text);
                CAL2 = double.Parse(TXTMAT.Text);
                CAL3 = double.Parse(TXTHISTORIA .Text);
                CAL4 = double.Parse(TXTLECTURA .Text);
                CAL5 = double.Parse(TXTCONT .Text);
                PROM = (CAL1 + CAL2 + CAL3 + CAL4 + CAL5) / 5;
                TXTPROM.Text = Convert.ToString(PROM);
            }
        }

        private void TXTREGISA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
