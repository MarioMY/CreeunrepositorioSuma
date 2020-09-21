using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear o declarar las variables a utilizar
            int n1, n2, n3, s;

            //Preguntar el valor de un numero
            Console.Write("N1: ");
            n1 = Int32.Parse(Console.ReadLine());
            //Preguntar el valor del segundo numero
            Console.Write("N2: ");
            n2 = Int32.Parse(Console.ReadLine());
            //Preguntar el valor del tercer numero
            Console.Write("N3: ");
            n3 = Int32.Parse(Console.ReadLine());
            //Sumarlos
            s = n1 + n2 + n3;
            //Mostrar el resultado

            Console.Write("Resultado "+s);

            Console.ReadKey();
        }
    }
}
