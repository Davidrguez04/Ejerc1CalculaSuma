using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1CalculaSuma.Servicios
{
    /// <summary>
    /// iMPLEMENTACION DE LAS ACCIONES DEL pedir numero
    /// 241023 - David RA
    /// </summary>
    internal class ImplNumero:InterfazNumero
    {

        //Método para pedir numero por consola
        public int pedirNumero()
        {
            int num1;

            do
            {
                Console.WriteLine("Introduzca un numero entero mayor que 0: ");
                num1 = Convert.ToInt32(Console.ReadLine());
            } while (num1 <= 0);
            
           
            return num1;

        }



    }


}
