using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            // Hacemos uso de la interfaz
            ITarget calcu;

            // Hacemos uso del adaptador
            calcu = new Adaptador();

            // Usamos el adaptador para realizar la operacion
            resultado = calcu.sumar(20, 20);
            Console.WriteLine("El resultado es {0}", resultado);

            Console.ReadKey();
        }
    }
}
