using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{
    public class Ejercicio3
    {
        public Ejercicio3()
        {

        }
        public void valores()
        {
            Console.WriteLine("ingrese primer  numero");
            String dato1 = Console.ReadLine();
            int val1 = Convert.ToInt32(dato1);
            Console.WriteLine("ingrese segundo numero");
            String dato2 = Console.ReadLine();
            int val2 = Convert.ToInt32(dato2);
            Console.WriteLine("tercer tercer numero");
            String dato3 = Console.ReadLine();
            int val3 = Convert.ToInt32(dato3);
            if (val1 > val2 && val1 > val3)
            {
                Console.WriteLine(dato1 + " es el mayor");
            }
            else if (val2 > val1 && val2 > val3)
            {
                Console.WriteLine(dato2 + " es  el mayor");
            }
            else
            {
                Console.WriteLine(dato3 + "es  el mayor");
            }
        }
    }
}

