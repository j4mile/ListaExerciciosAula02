//EXERCÍCIO 2. Ordenar três valores inteiros e diferentes em ordem decrescente.

namespace _2exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Vamos ordenas três valores inteiros em ordem decrescente.\nInsira o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o terceiro valor: ");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1);
                if (num2 > num3)
                {
                    Console.WriteLine(num2 + "\n" + num3);
                }
                else
                {
                    {
                        Console.WriteLine(num3 + "\n" + num2);
                    }
                }
            }

            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2);
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + "\n" + num3);
                }
                else
                {
                    Console.WriteLine(num3 + "\n" + num1);
                }
            }

            else
            {
                Console.WriteLine(num3);
                if (num1 > num2)
                {
                    Console.WriteLine(num1 + "\n" + num2);
                }
                else
                {
                    Console.WriteLine(num2 + "\n" + num1);
                }
            }

            Console.ReadKey();
        }
    }
}