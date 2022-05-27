using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{

    public class Ejercicio8
    {
        public Ejercicio8()
        {
        }
        public void ver()
        {
            int val = 1;
            Console.WriteLine(val);
            val = val - 1;
            do
            {
                val = val+ 3;
                Console.WriteLine(val);

            } while (val != 3000);
        }
    }
}
