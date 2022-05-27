using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{
    public class ejercicio2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese primer numero");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo numero 2: ");
            double num2 = double.Parse(Console.ReadLine());

            double sum = num1 + num2;

            Console.Write("El resultado es un numero ");
            if (sum % 2 == 0)
                Console.Write("Par");
            else
                Console.Write("Impar");

            
        }
    }
}