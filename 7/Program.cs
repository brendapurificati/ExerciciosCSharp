namespace Exercicio7
{
    class Exercicio7
    {
        static void Main()
        {
            /*Escreva um programa que leia um número inteiro e exiba o seu módulo.
            O módulo de um número x é:
            x se x é maior ou igual a zero
            x * (-1) se x é menor que zero */

            Console.WriteLine("Digite um valor inteiro: ");
            int a = int.Parse(Console.ReadLine());

            if (a<0)
            {
                Console.WriteLine($"O módulo de {a} é {a*(-1)}");
            }
            else {
                Console.WriteLine($"O módulo de {a} é {a}");
            }

        }
    }
}