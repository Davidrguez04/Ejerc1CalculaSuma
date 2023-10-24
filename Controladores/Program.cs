using Ejerc1CalculaSuma.Servicios;

namespace Ejerc1CalculaSuma.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de procedimientos de la aplicación
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método de entrada a la aplicación
        /// contiene el procedimiento o flujo de nuestra aplicación
        /// 241023 - David Rodriguez Alonso
        /// </summary>
        /// <param name="args"></param>



        static void Main(string[] args)
        {
            /*Escribe un programa que solicite un número entero mayor que 0 al usuario, lo lea de la consola y 
             * calcule la siguiente suma: 1+2+3...+n-1+n.
            Por ejemplo, si el número es 9, calculará 1+2+3+4+5+6+7+8+9.

            El método que solicite el número deberá estar definido en un servicio. El método mostrará el mensaje 
            de petición 
            de número, recogerá el número escrito en la consola y lo devolverá al método main.
            El método que calcule la suma y muestre por consola el resultado deberá estar definido también en un 
            servicio.*/

            //Objeto para usar las cosas de las clases
            InterfazNumero ni =new ImplNumero();
            InterfazCalculo mi=new ImplCalculo();

            
            int num=ni.pedirNumero();

            mi.calculoSuma(num);


        }
    }
}
