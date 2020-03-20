using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
   class CUADRADO:Class_figura 
    {
        public override double Perimetro()
            
        {
            Perimetro1  = Lado1 * 4;
            throw new NotImplementedException();
            
        }
        public override double area()
        {
            Area1 = Lado1 * Alura ;
            throw new NotImplementedException();
        }
    }
}
