using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARREGLOS
{
    class Arreglos
    {
        //main principal
        static void Main(string[] args)
        {
            Arreglos CAL = new Arreglos();
            CAL.Cargar();
            CAL .Imprimir();
        }

        private int[] calificaciones; //Declaramos un arreglo

        public void Cargar()
        {
            calificaciones = new int[6]; //Inicializamos el arreglo en 5
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("Ingrese calificacion " + f + ": ");
                string linea;
                linea = Console.ReadLine();
                calificaciones[f] = int.Parse(linea); //Asignamos las 5 calificaciones al arreglo
            }
        }
        //Muestra las calificaciones de los alumnos en el arreglo  calificaciones[f]
        public void Imprimir()
        {
            Console.Write("Las 5 calificaciones de los alumnos  \n");
            for (int f = 1; f <= 5; f++)
            {
                Console.Write("[" + calificaciones[f] + "] ");
            }
            Console.ReadKey();
        }

    }
}

