using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECIBO_DE_LUZ
{
    class CLASE_RECIBO
    {
        //ATRIBUTOS DE LA CLASE
        public double DIN, KW;
        public string LUGAR;
        //PROCEDIMIENTO DE LA CLASE
        public void LUZ()
        {
          switch (LUGAR )
            {
                case "CASA":
                    if (KW>=0 && KW <= 250)
                    {
                        DIN = KW * 0.65;
                    }
                    else
                    if (KW>=251 && KW <= 500)
                    {
                        DIN = KW * 0.85;
                    }
                    else 
                        if(KW>=501 && KW <=1200)
                    {
                        DIN = KW * 1.5;
                    }
                 else 
                        if (KW>=1201 && KW <=2100)
                    {
                        DIN = KW * 2.5;
                    }
                   else 
                        if (KW>=1201 )
                    {
                        DIN = KW * 3;
                    }
                    break;
                case "NEGOCIO":
                    DIN = KW * 5;
                    break;

            }
            
        }


    }

} 
