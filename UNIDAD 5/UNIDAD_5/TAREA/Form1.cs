using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA
{
    public partial class Form1 : Form
    {
        ArrayList PERSONAS = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void tsbNUEVO_Click(object sender, EventArgs e)
        {
            
            if (TXTID.Text == "")
            {
              errorProvider1.SetError (TXTID, "debe ingresar un ID");
            TXTID.Focus();
            return;
            }
            errorProvider1.SetError(TXTID, "");
            if(existe(TXTID .Text ))
            {
                errorProvider1.SetError(TXTID, "ID del empleado ya registrado");
                TXTID.Focus();
            }

            if (TXTNOMBRE.Text == "")
            {
                errorProvider1.SetError(TXTNOMBRE , "debe ingresar un nombre");
                TXTNOMBRE .Focus();
                return;
            }
            errorProvider1.SetError(TXTNOMBRE, "");

            if (TXTAPELLIDO .Text == "")
            {
                errorProvider1.SetError(TXTAPELLIDO , "debe ingresar un apellido");
                TXTAPELLIDO .Focus();
                return;
            }
            errorProvider1.SetError(TXTAPELLIDO , "");
            
            Regex regEMAIL =new Regex (@"^(([^<>()[\]\\.,;:\s@\ ""]+"

           + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"

           + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"

           + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"

           + @"[a-zA-Z]{2,}))$",
            RegexOptions.Compiled);

    if (!regEMAIL.IsMatch (TXTCORREO.Text ))
            {
                errorProvider1.SetError(TXTCORREO, "debe ingresar una direccion de correo valido");
                TXTCORREO .Focus();
                return;
            }
            errorProvider1.SetError(TXTCORREO , "");

            decimal salario;
            if (!decimal .TryParse(TXTSALARIO.Text, out salario ))
            {
                errorProvider1.SetError(TXTSALARIO , "debe ingresar numeros");
                TXTSALARIO .Focus();
                return;
            }
               errorProvider1.SetError(TXTCORREO , "");
          if (salario <0)
            {
                errorProvider1.SetError(TXTSALARIO, "debe ingresar numeros positivos ");
                TXTSALARIO.Focus();
                return;

            }
            PERSONA miPersona = new PERSONA();
            miPersona.ID = TXTID.Text;
            miPersona.NOMBRE  = TXTNOMBRE .Text;
            miPersona.CORREO  = TXTCORREO .Text;
            miPersona.APELLIDO  = TXTAPELLIDO .Text;
            miPersona.FECHA  =DTPFECHANACIMIENTO .Value ;
            miPersona.SALARIO = salario;
            PERSONAS.Add(miPersona);
            DGVDATOS.DataSource = null;
            DGVDATOS.DataSource = PERSONAS ;

            TXTAPELLIDO.Clear();
            TXTID .Clear();
            TXTNOMBRE .Clear();
            TXTCORREO .Clear();
            TXTSALARIO.Clear();
            TXTID.Focus();

        }

        private bool existe (string ID)
        {
            foreach (PERSONA persona in PERSONAS)
            {
                if (persona.ID == ID) return true;
            } 
                
          return false;
            

        }
    }
}
