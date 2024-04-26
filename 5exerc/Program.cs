//EXERCÍCIO 5. Realizar uma operação com base em dois valores inteiros A e B.

namespace _5exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, soma;

            Console.WriteLine("Informe o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor de B: ");
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("\n O valor de A + B: " + soma);
            Console.ReadKey();
        }
    }
}