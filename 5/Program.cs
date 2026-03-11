using System;

namespace Exercicio5
{
    class Exercicio5
    {
        static void Main()
        {
            Console.WriteLine("Digite a temperatura em graus Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (9*celsius+160)/5; 
            Console.WriteLine($"{celsius} em Celsius em Fahrenheit é {fahrenheit}. ");
        }
    }
}