using System;
using System.Globalization;

namespace exercicios1EstruturaSequencial02
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.14159;
            double area;

            Console.WriteLine("Digite o raio do círculo:");
            raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            area = pi * (Math.Pow(raio,2.0));

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
