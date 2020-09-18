using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Adapter
{
    // Esta es la clase adaptador que usa la interfaz ITarget
    // El adaptador comunica al program con la clase adaptada
    class Adaptador : ITarget
    {
        CalculadorArray adaptado = new CalculadorArray();

        // Aqui hacemos la adaptacion de una operacion
        public int sumar(int a, int b)
        {
            double r = 0;

            // Creamos el array que nesecita el adaptado
            // Adaptamos los datos que se envian
            int[] operadores = { a, b };

            // Realizamos la operacion en el adaptado
            r = adaptado.suma(operadores);

            // Adaptamos el resultado
            return (int)r;
        }
    }
}
