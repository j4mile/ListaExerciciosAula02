//EXERCÍCIO 3. Calcular o consumo de combustível por quilômetro.

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quilometInicial, quilometFinal, consumoComb, consumoKm;

            Console.WriteLine("Vamos calcular o seu consumo de combustível por quilômetro. Primeiro, informe a sua quilometragem inicial:");
            quilometInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora, informe a quilometragem final:");
            quilometFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPor último, informe o consumo de combustível total: ");
            consumoComb = int.Parse(Console.ReadLine());

            consumoKm = consumoComb / quilometFinal - quilometInicial;

            Console.WriteLine("\nO consumo de combustível por quilometro é de: " + consumoKm);

            Console.ReadKey();
        }
    }
}