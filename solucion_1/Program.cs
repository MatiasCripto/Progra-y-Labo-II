using System;

namespace solucion_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int suma = 0;
            float promedio = 0F;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                int num = int.Parse(Console.ReadLine());
                
                if(num > max)
                {
                    max = num;
                }
                if(num < min)
                {
                    min = num;
                }
                suma += num;
            }
            promedio = suma / 5;
            Console.WriteLine("El numero minimo es {0}, el maximo es {1} y el promedio es {2} ",min, max, promedio);


        }
    }
}
