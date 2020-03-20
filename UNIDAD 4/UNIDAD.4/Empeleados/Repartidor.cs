using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeleados
{
    class Repartidor : Empleado
    {
        double propinaSEM, ZONA, ABONOSCOBRADOS;
        public double PROPINA
        {
            set
            {
                propinaSEM  = value;
            }
            get
            {
                return PROPINA;
            }
        }
        public double ZONAS
        {
            set
            {
                ZONA = value;
            }
            get
            {
                return ZONAS;
            }
        }
        public double ABONO
        {
            set
            {
                ABONOSCOBRADOS = value;
            }
            get
            {
                return ABONO;
            }
        }
        public string zonas;


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

        public void SUELDO2()
        {
          
            switch (zonas)
            {
                case "ZONA 1":

                    ABONO = PROPINA * 5;
                    CALCULAR = DIAS * SUELDOO1  + ABONO;
                    break;
                case "ZONA 2":

                    ABONO = PROPINA * 2;
                    CALCULAR = DIAS* SUELDOO1 + ABONO ;
                    break;
            }


        }
    }
}
