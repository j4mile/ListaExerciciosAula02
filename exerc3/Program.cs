//EXERCÍCIO 3. Imprimir a sequência de Fibonacci até um número informado.

namespace exerc3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número para realizarmos a sequência de Fibonacci: ");
            int num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int temp;

            Console.WriteLine("Sequência de Fibonacci até " + num + ":");
            Console.Write(a + " " + b + " ");

            while (b <= num)
            {
                temp = a + b;
                if (temp <= num)
                {
                    Console.Write(temp + " ");
                }
                a = b;
                b = temp;
            }
            Console.ReadKey();
        }
    }
}