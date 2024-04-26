//Calcular o fatorial de um número e exibir o resultado.

namespace exerc2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fatorial;

            Console.WriteLine("Informe um número para calcular o fatorial: ");
            num = int.Parse(Console.ReadLine());

            fatorial = 1;
            for (int i = 1; i <= num; i++)
            {
                fatorial = fatorial * i;
            }
            Console.WriteLine("\nO fatorial é: " + fatorial);

            Console.ReadKey();
        }
    }
}