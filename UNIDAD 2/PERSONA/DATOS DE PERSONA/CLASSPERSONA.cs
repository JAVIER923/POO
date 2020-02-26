using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS_DE_PERSONA
{
    class CLASSPERSONA
    {
        //atributos
        public string NOMBRE, APPATEERNO, APMATERNO, TIPO, ESTADO;
        public int FECHA, TELEFONO, EDAD, conN = 0, ALUMNO = 0, DOCENTE = 0, ADMINISTRATIVO = 0, CONTAREDAD = 0;

        //metodos
        public void estado()
        {
            if (ESTADO == "Nayarit")
            {
                conN++;
            }

        }
        public void contartipo()
        {
            switch (TIPO)
            {
                case "ALUMNO":
                    {
                        ALUMNO++;
                        break;
                    }
                case "DOCENTE":
                    {
                        DOCENTE++;
                        break;
                    }
                default:
                    {
                        ADMINISTRATIVO++;
                        break;                 
                    }
            }
        }

        public void MAYOREDAD(int ANIO, int MES,int DIA,int ANIOACTUAL,int MESACTUAL,int DIAACTUAL)
        {

            {
                if (ANIOACTUAL - ANIO > 18)
                {
                    CONTAREDAD++;
                }
                else if (ANIOACTUAL - ANIO == 18)
                {
                    CONTAREDAD++;
                }
                else if (MESACTUAL < MES)
                {
                    CONTAREDAD++;
                }
                else if (DIAACTUAL > DIA )
                {
                    CONTAREDAD++;
                }
                
            }

        }

           
    }
}
