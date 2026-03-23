namespace Exercicio9
{
    class Exercicio9
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Digite o nome da pessoa 1: ");
            p1.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa 1: ");
            p1.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da pessoa 2: ");
            p2.nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da pessoa 2: ");
            p2.idade = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"Dados da primeira pessoa: \nNome: {p1.nome}\nIdade: {p1.idade}");
            Console.WriteLine($"Dados da segunda pessoa: \nNome: {p2.nome}\nIdade: {p2.idade}");
            if (p1.idade>p2.idade)
            {
                Console.WriteLine($"{p1.nome} é mais velho(a) do que {p2.nome}.");
            }
            else
            {
                Console.WriteLine($"{p2.nome} é mais velho(a) do que {p1.nome}.");
            }
        }
    }
}