using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacion
{
    class OPERACION
    {
        //ATRIBUTOS DE LA CLASE       
        float valor1, valor2, resultado;

        public float  Valor1
        {
             get
            {
                return valor1;
            }
            set
            {
                valor1 = value;
            }


        }

        public float Valor2
        {
            get
            {
                return valor2;
            }
            set
            {
                valor2 = value;
            }


        }

        public float Resultado
        {
            get
            {
                return resultado ;
            }
            set
            {
                resultado  = value;
            }


        }
      public OPERACION ()
        {
            valor1 = 0;
            valor2 = 0;
            resultado = 0;

        }

            








    }

}

