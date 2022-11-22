using System;

namespace peso_ideal
{
    internal class Program
    {
        private static double peso = 0;

        static double pesoMujer(double altura)
        {
            peso = ((72.7 * altura) - 58);
            return Math.Round(peso, 2);
        }

        static double pesoHombre(double altura)
        {
            peso = ((62.1 * altura) - 44.7);
            return peso;
        }


        static void Main(string[] args)
        {
            double altura = 0;
            char sexo;

            try
            {
                Console.WriteLine("Ingrese su altura en cm (Ej.: 1.50): ");
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Indique su sexo M o F (M = Masculino y F = Femenino): ");
                sexo = char.Parse(Console.ReadLine());

                if (sexo == 'F' || sexo == 'f')
                {
                    Console.WriteLine($"Mi peso ideal: {pesoMujer(altura)}");
                } 

                if (sexo == 'M' || sexo == 'm')
                {
                    Console.WriteLine($"Mi peso ideal: {pesoHombre(altura)}");
                }
            } 
            catch(Exception e)
            {
                Console.Beep();
                Console.WriteLine("\nError: " + e.Message);
            }


            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
