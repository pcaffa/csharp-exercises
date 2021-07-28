using System;
using System.Globalization;

namespace exercicios1EstruturaSequencial05
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qtd1, qtd2;
            double preco1, preco2, result;

            Console.Write("Insira o codigo, qtd e valor da peça 1: ");
            string[] values1 = Console.ReadLine().Split(' ');
            cod1 = Convert.ToInt32(values1[0]);
            qtd1 = Convert.ToInt32(values1[1]);
            preco1 = double.Parse(values1[2], CultureInfo.InvariantCulture);

            Console.Write("Insira o codigo, qtd e valor da peça 2: ");
            string[] values2 = Console.ReadLine().Split(' ');
            cod2 = Convert.ToInt32(values2[0]);
            qtd2 = Convert.ToInt32(values2[1]);
            preco2 = double.Parse(values2[2], CultureInfo.InvariantCulture);

            result = (qtd1 * preco1) + (qtd2 * preco2);
            Console.WriteLine("VALOR A PAGAR: R$" + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
