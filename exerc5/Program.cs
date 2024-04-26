//EXERCÍCIO 5. Exibir a tabuada de multiplicação do 1 ao 10.

namespace exerc5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int num = 1; num <= 10; num++)
            {
                Console.WriteLine("\nTabuada do " + num);
                for (int mult = 1; mult <= 10; mult++)
                {
                    int result = num * mult;
                    Console.WriteLine(num + " x " + mult + " = " + result);
                }
            }

            Console.ReadKey();
        }
    }
}