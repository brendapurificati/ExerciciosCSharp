using System;

namespace exercicio4
{
    class exercicio4
    {
        static void Main()
        {
            Console.WriteLine("Digite o tempo de viagem em horas: ");
            double tempo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade média da viagem: ");
            double velocidade = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a distância da viagem: ");
            double distancia = tempo*velocidade;
            double litros_usados = distancia/12;
            Console.WriteLine($"Tempo: {tempo}\nVelocidade média: {velocidade}\nDistância: {distancia}\nLitros usados: {litros_usados}.");
        }
    }
}