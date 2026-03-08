using System;

namespace Exercicio2
{
    class Exercicio2
    {
        static void Main()
        {
            double cot_dolar = double.Parse(Console.ReadLine());
            double val_dolar = double.Parse(Console.ReadLine());
            double val_real = cot_dolar*val_dolar;
            Console.WriteLine($"Valor de {val_dolar} dólares, com a cotação {cot_dolar}, em real: {val_real}");
        }
    }
}