using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_Perimetro
{
    class claseCuadrado
    {
        // ATRIBUTOS DE LA CLASE
        public int AREA;
        public int PERIMETRO;
        public int num1;

        //METODOS DE LA CLASE
        public void CALCULAR()
        {
            AREA =( num1 * num1 );
            PERIMETRO = (num1 * 4);
        }

        internal void CALCULAR(Func<string> toString)
        {
            throw new NotImplementedException();
        }
    }
}
