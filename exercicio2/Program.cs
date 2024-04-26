//EXERCÍCIO 2. Converter a temperatura de graus Fahrenheit para graus Celsius.

namespace exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertor de Fahrenheit para Celsius\n\nInsira a temperatura em Fahrenheit:");
            double tempFahren = double.Parse(Console.ReadLine());

            double tempCelsius = (tempFahren - 32) * 5 / 9;

            Console.WriteLine("\nA temperatura convertida para graus em Celsius é: " + tempCelsius);

            Console.ReadKey();
        }
    }
}