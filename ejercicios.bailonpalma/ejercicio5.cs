using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{

    public class Ejercicio5
    {
        public Ejercicio5()
        {

        }
        public void suma()
        {
            int total = 0;
            for (int x = 0; x <= 8; x++)
            {

                Console.WriteLine("ingrese un numero");
                String valor = Console.ReadLine();
                int num = Convert.ToInt32(valor);
                total = num + total;

            }
            Console.WriteLine("La suma de todos los numeros es: " + total);
        }
    }
}
