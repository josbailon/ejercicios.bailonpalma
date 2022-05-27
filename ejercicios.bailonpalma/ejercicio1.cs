using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios.bailonpalma
{
    public class ejercicio1
    {
       
            static void Main(string[] args)
            {
                int num1, num2, mayor;
                Console.Write("Ingresa el primer");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Ingresa el  segundo valor ");
                num2 = int.Parse(Console.ReadLine());
                if (num1 > num2)
                    mayor = num1;
                else
                    mayor = num2;
                Console.WriteLine("Valor de mayor: " + mayor);
               
                
            }
        }
    }
