using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEHICULO
{
    class vehiculo
    {
        //atributos de la clase
        public string tipocombustible, color, arrancarmotor, paramotor, sonido;
        public int numllantas, numpuertas, numventanas;

        /*constructor de la clase, es un metodos que se
          llama igual que la clase y se ejecuta automaticamenteal crear el objeto*/
         public vehiculo ()
        {
            tipocombustible = "";
            color ="blanco";
            numllantas = 1;
            numpuertas  = 0;
            numventanas = 0;
           
        }
        public string ArrancarMotor()
        {
            sonido = "(run run)";

            return "se arranco el motor:   " + sonido;
        }
        public string Paramotor()
        {
            sonido = "(lmfgñlmbñntfmpshhhhh)";
            return "se apago el motor: " + sonido;
        }
    }
}
