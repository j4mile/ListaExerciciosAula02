//EXERCÍCIO 1. Calcular o volume de uma caixa retangular.

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura, largura, comprimento;

            Console.WriteLine("Vamos calcular o volume de uma caixa retangular. Primeiro, informe a altura: ");
            altura = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a largura: ");
            largura = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o comprimento: ");
            comprimento = int.Parse(Console.ReadLine());

            int volume = altura * largura * comprimento;

            Console.WriteLine("\nO volume da caixa é de " + volume + " unidades cúbicas.");

            Console.ReadKey();
        }
    }
}