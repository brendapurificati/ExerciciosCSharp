using System;

namespace exercicio4
{
    class exercicio4
    {
        static void Main()
        {
            /* Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz
            12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média.
            Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE.
            Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a
            fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média,
            tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.*/

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