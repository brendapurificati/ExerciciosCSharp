namespace Exercicio6
{
    class Exercicio6
    {
        static void Main()
        {
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