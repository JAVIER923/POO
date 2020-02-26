using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENBOTELLADORA
{
    class ClassBotella
    {
        //Atrubutos de la clase
        public int nivelLlenado;
        int mililitrosVerificado;
        //metodos de la clase
        public string verificarLlenado()
        {
            string mensaje;
            if (nivelLlenado == 250)
                mensaje = "llenado perfecto";
            else if (nivelLlenado < 250)
            {
                mililitrosVerificado = 250 - nivelLlenado;
                mensaje = "le falta" + mililitrosVerificado + "mililitros";
            }
            else
            {
                mililitrosVerificado = nivelLlenado - 250;
                mensaje = "le sobran" + mililitrosVerificado + "mililitros";
            }
            return mensaje;


        }
    }
}
