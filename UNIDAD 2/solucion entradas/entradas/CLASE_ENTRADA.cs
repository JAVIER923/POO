using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entradas
{
    public class CLASE_ENTRADA
    {
        //atrubutos de la clase
        public int num1 = 0;
        public string persona;

       //variables   
        public int bebes = 0;
        public int niños = 0;
        public int adultos = 0;
        public int terceraedad = 0;
     
        //metodos de la clase
        public int inventario()
        {
            switch (persona)
            {
                case "BEBES":
                    bebes = bebes + num1;
                    break;
                case "NIÑOS":
                    niños = niños + num1;
                    break;
                case "ADULTOS":
                    adultos = adultos + num1;
                    break;
                case "TERCERA EDAD":
                    terceraedad = terceraedad + num1;
                    break;
                
            }


            return num1;


        }
            
        
        
            

            

        

    }
}
