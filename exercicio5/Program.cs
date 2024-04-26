//EXERCÍCIO 5. Calcular a média ponderada de duas provas realizadas por um aluno.

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double nota1, peso1, nota2, peso2, media;

            Console.WriteLine("Vamos calcular a média ponderada de duas provas realizadas por um aluno. Informe a nota da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o peso da primeira prova: ");
            peso1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o peso da segunda prova: ");
            peso2 = double.Parse(Console.ReadLine());

            media = (nota1 * peso1) + (nota2 * peso2);

            Console.WriteLine("\nA média ponderada das duas provas é: " + media);

            Console.ReadKey();
        }
    }
}