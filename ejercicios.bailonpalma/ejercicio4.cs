using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{
    public class Ejercicio4
    {
        public Ejercicio4()
        {

        }
        public void ingresar()
        {
            int valor;
            do
            {
                Console.WriteLine("Escriba un numero");
                String dato = Console.ReadLine();
                valor = Convert.ToInt32(dato);
            } while (valor != 0);

        }
    }
}
