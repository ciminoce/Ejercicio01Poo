using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Cuadrado c = new Cuadrado();
            //    c.Lado = -5;

            //    Console.WriteLine($"La medida del lado es {c.Lado}");

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}  
            //Cuadrado c = new Cuadrado();
            //c.Lado = 10;
            Cuadrado c = new Cuadrado(10);
            Cuadrado c2 = new Cuadrado();
            Cuadrado c3 = new Cuadrado() {Lado = 15};
            if (c.Validar())
            {
                Console.WriteLine($"La medida del lado es {c3.Lado}");
                Console.WriteLine($"Su perímetro es {c3.GetPerimetro()}");
                Console.WriteLine($"La superficie es {c3.GetSuperficie()}");
                
            }
            else
            {
                Console.WriteLine("Objeto no válido");
            }
            Console.ReadLine();

        }
    }
}
