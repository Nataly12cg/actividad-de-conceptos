using System;

namespace PositivePower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número: ");
            if (double.TryParse(Console.ReadLine(), out double numero))
            {
                if (numero > 0)
                {
                    double resultado = Math.Pow(numero, 2);
                    Console.WriteLine($"Resultado: {resultado}");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("Resultado: Número negativo.");
                }
                else
                {
                    Console.WriteLine("Resultado: 0");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número válido.");
            }
        }
    }
}

