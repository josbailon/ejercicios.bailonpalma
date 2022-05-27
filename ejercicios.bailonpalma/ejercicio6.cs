using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{
    public class Ejercicio6
    {
        public Ejercicio6()
        {

        }
        public void suma1()
        {
            int val;
            int resultado = 0;
            do
            {
                Console.WriteLine("ingrese un numero");
                String valor = Console.ReadLine();
                val = Convert.ToInt32(valor);
                resultado = val + resultado;
            } while (val != 0);
            Console.WriteLine("El resultado de  la suma es " + resultado);
        }
    }
}