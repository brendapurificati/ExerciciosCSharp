namespace Exercicio6
{
    class Exercicio6
    {
        static void Main()
        {
            /*Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes
            entre eles. Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual.*/

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a==b)
            {
                Console.WriteLine("São iguais.");
            } 
            else
            {
             Console.WriteLine("Não são iguais.");   
            }

            if (a>b)
            {
                Console.WriteLine($"{a} é maior e {b} é menor.");
            }
            else if (a<b)
            {
                Console.WriteLine($"{b} é maior e {a} é menor.");
            }

            if (a>=b)
            {
                Console.WriteLine($"{a} é maior ou igual que {b}.");
            }
            else if (a<=b)
            {
                Console.WriteLine($"{b} é maior ou igual que {a}.");
            }
        }
    }
}