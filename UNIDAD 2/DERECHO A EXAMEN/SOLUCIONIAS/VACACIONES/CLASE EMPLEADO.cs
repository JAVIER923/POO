using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VACACIONES
{
    class CLASE_EMPLEADO
    {
        //ATRIBUTOS DE LA CLASE
        public int ANIOS, DIAS;
           //METODOS DE LA CLASE
           public void VACACIONES()
        {
            if (ANIOS>=1 && ANIOS<=5 )
            {
                DIAS = 5;
            }
            else 
                if (ANIOS >=6 && ANIOS <=10)
            {
                DIAS = 10;
            }
            else 
                if (ANIOS>=11 && ANIOS<=20)
            {
                DIAS = ANIOS ;
            }
            else 
                if (ANIOS>=21 && ANIOS<=32)
            {
                DIAS = ANIOS *2-20;

            }
            else
            {
                DIAS = 45;
            }
        }


    }
}
