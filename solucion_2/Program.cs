using System;

namespace solucion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero:");
            int numero;
            if(int.TryParse(Console.ReadLine(), out numero))
            {
                if(numero > 0)
                {
                    double cuadrado = Math.Pow(numero,2);
                    double cubo = Math.Pow(numero, 3);
                    Console.WriteLine("El numero ingresado es {0}, este numero al cuadrado es {1} y al cubo {2}", numero, cuadrado, cubo);
                }
                else
                {
                    Console.WriteLine("error, reingresar el numero.");
                }
            }
            else
            {
                Console.WriteLine("Eso no es un numero.");
            }
        }
    }
}
