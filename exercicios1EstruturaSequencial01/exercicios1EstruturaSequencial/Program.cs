using System;

namespace exercicios1EstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro número:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("SOMA = " + (num1 + num2) );
        }
    }
}
