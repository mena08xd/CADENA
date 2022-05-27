using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADENA
{
    class Class1
    {
        static void Main(string[] args)
        {
            String cadena;
            int num1 = 5, num2, resultado;

            Console.Write("Dame un numero para sumarlo: ");
            cadena = Console.ReadLine();
            num2 = Int32.Parse(cadena);
            resultado = num1 + num2;
            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();
        }
    }
}
