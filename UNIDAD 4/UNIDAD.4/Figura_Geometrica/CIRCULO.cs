using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
   class CIRCULO:Class_figura 
    {
        public override double Perimetro()
        {
            Perimetro1 = (Lado1 * 2) * 3.1416;
            throw new NotImplementedException();

        }
        public override double area()
        {

            Area1 = 3.1416*(Lado1 * Lado1);
            throw new NotImplementedException();
        }
    }
}
