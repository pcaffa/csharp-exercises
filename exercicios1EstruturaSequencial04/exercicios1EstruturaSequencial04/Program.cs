using System;
using System.Globalization;

namespace exercicios1EstruturaSequencial04
{
    class Program
    {
        static void Main(string[] args)
        {
            int codEmployee = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double hourValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double salary = hours * hourValue;

            Console.WriteLine("");
            Console.WriteLine("NUMBER = " + codEmployee);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
