using System;

namespace Ejercicios03Programacion01ArrayFunciones.Con
{
    class Program
    {
        static void Main(string[] args)
        { 
            double[] arrayAltura = new double[7];
            for (int i = 0; i < 7; i++)
            {
                bool esError = true;
                double altura;
                do
                {
                    Console.Write($"Ingrese la {i + 1}° altura:");
                    if (double.TryParse(Console.ReadLine(), out altura))
                    {
                        if (altura >= 120 && altura <= 230)
                        {
                            Console.WriteLine($"La altura es {altura}cm");
                            arrayAltura[i] = altura;
                            esError = false;
                        }
                        else
                        {
                            Console.WriteLine("Altura fuera del rango");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor mal ingresado,intente devuelta");
                    }
                } while (esError);
                
            }
            var mayorAltura = CalcularMayor(arrayAltura);
            var menorAltura = CalcularMenor(arrayAltura);
            var promedioAltura = CalcularPromedio(arrayAltura);


            MostrarVector(arrayAltura, promedioAltura);
            Console.WriteLine($"La mayor altura es {mayorAltura}cm");
            Console.WriteLine($"La menor altura es {menorAltura}cm");
            Console.WriteLine($"El promedio de altura es {promedioAltura}");
            Console.ReadLine();
        }
        private static void MostrarVector(double[] arrayAltura, double promedio)
        {
            foreach (var altura in arrayAltura)
            {
                if (altura < promedio)
                {
                    Console.WriteLine($"{altura}*");
                }
                else
                {
                    Console.WriteLine($"{altura}");
                }
            }
        }
        private static double CalcularPromedio(double[] arrayAltura)
        {
            double promedioAlturaEnFuncion = 0;
            foreach (var altura in arrayAltura)
            {
                promedioAlturaEnFuncion += altura;
            }
            return promedioAlturaEnFuncion / 7;
        }

        private static double CalcularMenor(double[] arrayAltura)
        {
            double menorAlturaEnFuncion = double.MaxValue;
            foreach (var altura in arrayAltura)
            {
                if (altura < menorAlturaEnFuncion)
                {
                    menorAlturaEnFuncion = altura;
                }
            }
            return menorAlturaEnFuncion;
        }

        private static double CalcularMayor(double[] arrayAltura)
        {
           double mayorAlturaEnFuncion = double.MinValue;
           foreach (var altura in arrayAltura)
            {
                if (altura>mayorAlturaEnFuncion)
                {
                    mayorAlturaEnFuncion = altura;
                }
            }
            return mayorAlturaEnFuncion;
        }
    }
    
}
