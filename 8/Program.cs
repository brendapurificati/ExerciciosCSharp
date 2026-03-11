namespace Exercicio8
{
    class Exercicio8
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine($"A diferença de {a} e {b} é {a-b}");
            } 
            else if (a<b)
            {
                Console.WriteLine($"A diferença de {a} e {b} é {b-a}");
            }
            else if (a == b)
            {
                Console.WriteLine($"A diferença de {a} e {b} é 0, pois são iguais.");
            }
        }
    }
}