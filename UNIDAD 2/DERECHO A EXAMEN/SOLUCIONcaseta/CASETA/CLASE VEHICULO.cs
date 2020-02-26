using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASETA
{
    class CLASE_VEHICULO
    {
        //ATRIBUTOS DE LA CLASE
        public int PRECIO;
        public string VEHICULO;
        //METODOS DE LA CLASE
        public void PRECIOS()
        {
            switch (VEHICULO )
            {
                case "MOTOCICLISTA":
                    PRECIO = 50;
                    break;
                case "AUTOMOVIL":
                    PRECIO = 112;
                    break;
                case "AUTOBUS":
                    PRECIO = 120;
                    break;
                case "TRAILER":
                    PRECIO = 250;
                    break;
                
                   
                    
            }
        }  
            
    }
}
