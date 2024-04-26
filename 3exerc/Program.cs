//EXERCÍCIO 3. Calcular o Índice de Massa Corporal (IMC) e determinar a condição de peso de um adulto.

namespace _3exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura, imc;

            Console.WriteLine("Vamos calcular seu IMC. Primeiramente, informe seu peso:");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("\nAgora, informe sua altura:");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("\nSeu IMC: " + imc + " (MAGREZA)");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("\nSeu IMC: " + imc + " (NORMAL)");
            }
            else if (imc >= 24.9 && imc < 29.9)
            {
                Console.WriteLine("\nSeu IMC: " + imc + " (SOBREPESO I)");
            }
            else if (imc >= 30 && imc < 39.9)
            {
                Console.WriteLine("\nSeu IMC: " + imc + " (OBESIDADE II)");
            }
            else
            {
                Console.WriteLine("\nSeu IMC: " + imc + " (OBESIDADE GRAVE III)");
            }

            Console.ReadKey();
        }
    }
}