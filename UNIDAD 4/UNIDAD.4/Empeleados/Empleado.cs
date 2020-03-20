using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empeleados
{
    abstract class Empleado
    {
        double FechadeNacimiento, DiasTrabajados, CalcularSueldo, SUELDO, NOMBRE1;


        public double NOMBRE
        {
            set
            {
                NOMBRE1 = value;
            }
            get
            {
                return NOMBRE;
            }
        }
        public double FECHADENACIMIENTO
        {
            set
            {
                FechadeNacimiento = value;
            }
            get
            {
                return FECHADENACIMIENTO;
            }
        }
        public double DIAS
        {
            set
            {
                DiasTrabajados = value;
            }
            get
            {
                return DIAS;
            }
        }
        public double CALCULAR
        {
            set
            {
                CalcularSueldo = value;
            }
            get
            {
                return CALCULAR;
            }
        }
        public double SUELDOO1
        {
            set
            {
                SUELDO = value;
            }
            get
            {
                return SUELDOO1;
            }
        }
        public abstract double calcular();
        public abstract double dias();
        public abstract double sueldo();











    }
   
}
