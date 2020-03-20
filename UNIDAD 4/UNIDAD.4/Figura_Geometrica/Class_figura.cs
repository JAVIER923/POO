using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figura_Geometrica
{
   abstract  class Class_figura
    {
        double lado1, altura2, perimetro1,area1;

        public double Lado1
        {
            set
            {
                lado1 = value;
            }
            get
            {
                return Lado1;
            }
      
        }
        public double Alura
        {
            set
            {
                altura2 = value;
            }
            get
            {
                return altura2;
            }
        }
        public double Perimetro1
        {
         set
            {
                perimetro1 = value;
            }
            get
            {
                return perimetro1;
            }

        }
        public double Area1
        {
            set
            {
                area1 = value;
            }
            get
            {
                return area1;
            }
        }


        public abstract double  Perimetro();

        public abstract double area();


       

    }
 

}

