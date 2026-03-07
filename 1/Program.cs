using System;

namespace exercicio1
{
    class exercicio1
    {
        static void Main()
        {
            double qntd_min, qntd_max, estoque;
            string peca;

            Console.WriteLine("Digite o nome da peça: ");
            peca = Console.ReadLine();
            Console.WriteLine("Digite a quantidade mínima para a peça:");
            qntd_min = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade máxima: ");
            qntd_max = double.Parse(Console.ReadLine());
            estoque = (qntd_min+qntd_max)/2;
            Console.WriteLine($"O estoque médio de {peca} é: {estoque}");
        }
    }
}