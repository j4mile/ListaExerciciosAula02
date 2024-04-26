//EXERCÍCIO 4. Calcular o salário total de um vendedor.

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioBase, totalVendas, salarioTotal;
            int comissao;

            Console.WriteLine("Vamos calcular o salário total de um vendedor. Primeiro, informe o salário base: ");
            salarioBase = double.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora informe o total de vendas: ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.WriteLine("\nPor último, informe a taxa de comissão: ");
            comissao = int.Parse(Console.ReadLine());

            salarioTotal = salarioBase + (totalVendas * comissao);

            Console.WriteLine("\nO salário total do vendedor é de: " + salarioTotal);

            Console.ReadKey();
        }
    }
}