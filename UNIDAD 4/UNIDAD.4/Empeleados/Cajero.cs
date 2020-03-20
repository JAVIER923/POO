using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeleados
{
    class Cajero : Empleado
    {
        int CAJA;
        public string CAJAS1;
        public int CAJAS
        {
            set
            {
                CAJA = value;
            }
            get
            {
                return CAJAS;
            }
        }

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

        public void SUELDOO()
        {

            switch (CAJAS1)
            {
                case "CAJA 1":
                    CALCULAR = SUELDOO1;
                    break;
                case "CAJA 2":
                    CALCULAR = 3 * SUELDOO1 / 100;
                    break;
            }



        }
    }
}
