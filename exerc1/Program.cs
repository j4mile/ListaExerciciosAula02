//EXERCÍCIO 1. Gerar e escrever os números ímpares entre 100 e 200.

namespace exerc1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}