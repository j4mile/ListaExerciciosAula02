//EXERCÍCIO 1. Verificar se a soma de A + B é menor que C.

namespace _1exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Vamos verificas se a soma de A + B é menor que C.\n\nInforme o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor de B: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor de C: ");
            c = int.Parse(Console.ReadLine());

            if (a + b < c)
            {
                Console.WriteLine("\nA + B é menor que C.");
            }
            else
            {
                Console.WriteLine("\nA + B é maior que C.");
            }

            Console.ReadKey();
        }
    }
}