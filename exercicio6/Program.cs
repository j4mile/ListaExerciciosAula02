//EXERCÍCÍO 6. Calcular a área de um terreno retangular.

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal compTerreno, larguraTerreno, areaTerreno;

            Console.WriteLine("Vamos calcular a área de um terreno retangular. Primeiro, informe o comprimento do terreno: ");
            compTerreno = decimal.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora informe a largura: ");
            larguraTerreno = decimal.Parse(Console.ReadLine());

            areaTerreno = compTerreno + larguraTerreno;

            Console.WriteLine("\nA área do terreno é de: " + areaTerreno + "m².");

            Console.ReadKey();

        }
    }
}