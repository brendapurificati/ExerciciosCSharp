namespace Exercicio7
{
    class Exercicio7
    {
        static void Main()
        {
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