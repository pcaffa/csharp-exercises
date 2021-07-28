using System;

namespace exercicios1EstruturaSequencial03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            Console.WriteLine("Digite o valor de A:");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de B:");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de C:");
            C = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor de D:");
            D = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DIFERENCA = " + (A * B - C * D));
        }
    }
}
