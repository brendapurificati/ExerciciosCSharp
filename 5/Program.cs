using System;

namespace Exercicio5
{
    class Exercicio5
    {
        static void Main()
        {
            /*Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de
            temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus
            Fahrenheit e a variável C representa é a temperatura em graus Celsius*/

            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (9*celsius+160)/5; 
            Console.WriteLine($"{celsius} em Celsius em Fahrenheit é {fahrenheit}. ");
        }
    }
}