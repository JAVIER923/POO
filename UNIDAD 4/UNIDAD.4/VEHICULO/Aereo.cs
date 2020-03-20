using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEHICULO
{
    class Aereo:vehiculo
    {
     public int numturbinas, Numalas, numElices;
        public string tipoAero, estado;

        public Aereo ()
        {
            Numalas = 0;
            numElices = 0;
            numturbinas = 0;
            tipoAero = "";
        }
        public string enVuelo()
        {
            estado = " Volando ";
            return "el " + tipoAero + " esta "+ estado ;
        }
            
    }
}
