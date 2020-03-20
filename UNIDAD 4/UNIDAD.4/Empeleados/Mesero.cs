using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeleados
{
    class Mesero:Empleado 
    {
       public  string   MESERO;
        double PROPINASEMANAL;
        public double propina
        {
            set
            {
                PROPINASEMANAL = value;
            }
            get
            {
                return propina;
            }
        }
       public  string  MESERO1;
        public override double calcular()
        {
            throw new NotImplementedException();
        }

        public override double dias()
        {
            throw new NotImplementedException();
        }
        public override double sueldo()
        {
            throw new NotImplementedException();
        }

        public void SUELDO1()
        {

            CALCULAR = SUELDOO1 * DIAS + propina ;
        }
        

            
      
              
                
            
  
        


    }
}
