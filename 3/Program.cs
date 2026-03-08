using System;

namespace Exercicio3
{
    class Exercicio3
    {
        static void Main()
        {
            /* Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
            comissão será de 5% do total da venda e que você tem os seguintes dados:
            - Identificação do vendedor
            - Código da peça
            - Preço unitário da peça
            - Quantidade vendida*/

            Console.WriteLine("Digite o nome do vendedor: ");
            string vendedor = Console.ReadLine();
            Console.WriteLine("Digite o código da peça: ");
            int cod_peca = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da peça: ");
            double preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de peças vendidas: ");
            int quant_venda = int.Parse(Console.ReadLine());

            double val_venda = preco*quant_venda;
            double comissao = val_venda*0.05;
            Console.WriteLine($"A comissão do vendedor {vendedor}, na venda da peça código {cod_peca}, é de: {comissao}.");
        }
    }
}