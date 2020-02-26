using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temperatura
{
    class TEMPERATURA
    {
        //ATRIBUTOS DE CLASE
        public double CENT,FAHREN, NUM1;
        public string temperatura;
        //METODOS DE LA CLASE
        public void MODIFICACION()
        {
            switch (temperatura )
            {
                case "fahrenheit":
                    CENT = (NUM1 - 32) / 1.8;
                    break;
                case "centigrados":
                    FAHREN = (NUM1 * 1.8) + 32;
                    break;
                        
            }

        }
    }
}
