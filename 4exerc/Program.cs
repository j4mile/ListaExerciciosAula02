//EXERCÍCIO 4. Identificar se um número é par ou ímpar.

namespace _4exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, verifica;

            Console.WriteLine("Insira um número para verificar se ele é par ou ímpar:");
            num = int.Parse(Console.ReadLine());

            verifica = num % 2;

            if (verifica == 0)
            {
                Console.WriteLine("\nO número é par.");
            }
            else
            {
                Console.WriteLine("\nO número é ímpar.");
            }

            Console.ReadKey();
        }
    }
}