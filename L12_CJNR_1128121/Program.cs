using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_CJNR_1128121
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] puntos = new int[15];
            double suma = 0.0, media = 0.0;
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(" Ingrese una nota: ");
                    puntos[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < 15; i++)
                {
                    suma += puntos[i];
                }
                Console.WriteLine(" La suma es: " + suma);
                media = suma / 15;
                Console.WriteLine("La media es: " + media);
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR! Ingrese un numero");
            }
            Console.ReadKey();
        }
    }
}
