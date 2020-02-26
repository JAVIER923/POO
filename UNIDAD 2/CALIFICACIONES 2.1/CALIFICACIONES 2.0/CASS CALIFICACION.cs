using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALIFICACIONES_2._0
{
    class CASS_CALIFICACION
    {
        //atributos de la clase
        public decimal califCapturada = 0, promediogrupal1, sumacalif;
        public int reprobados = 0;
        public int aprobados = 0;
      
        //metodos de la clase
        public void contaraprobacion()
        {
            if (califCapturada < 70 && califCapturada > 0)
            {
                reprobados++;

            }
            else
            {
                aprobados++;
            }   
            sumacalif += califCapturada;
            promediogrupal1 = sumacalif / (aprobados + reprobados);
        }




    }
        
    
    
}
