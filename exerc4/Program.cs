//EXERCÍCIO 4. Substituir múltiplos de 3 pela palavra "Fizz" e múltiplos de 5 pela palavra "Buzz" na contagem de 1 a 100.

namespace exerc4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 00)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 00)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}