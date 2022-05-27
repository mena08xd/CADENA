using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADENA
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.WriteLine("Como te llamas: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola" + " " + nombre + " " + "Quieres ver el menu? ");
            Console.ReadKey();
        }
    }
}