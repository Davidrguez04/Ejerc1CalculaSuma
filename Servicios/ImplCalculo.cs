using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc1CalculaSuma.Servicios
{
    /// <summary>
    /// iMPLEMENTACION DE LAS ACCIONES DEL calculo
    /// 241023 - David RA
    /// </summary>
    internal class ImplCalculo:InterfazCalculo
    {
        //Método para calcular la suma
        public int calculoSuma(int num)
        {
            int suma = 0;
            for(int i=1;i<=num;i++)
            {
               
                

                if (i == num)
                {
                    Console.Write(i);
                    suma += i;
                }
                else
                {
                    Console.Write(i + "+");
                    suma += i;
                }

            }
            Console.WriteLine("="+suma);
            return num;
        }
    }
}
