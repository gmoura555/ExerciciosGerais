using System.Diagnostics;

namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Write("Digite a Idade:");

            idade = int.Parse(Console.ReadLine());
            int dias = idade * 365;
            int Ndias = dias;

            int meses = idade * 12;
            int Nmeses = meses;

            Console.WriteLine($"A idade do usuário: {idade}");
            Console.WriteLine($"O número de dias que a pessoa vive: {dias}");
            Console.WriteLine($"O número de meses que a pessoa vive: {meses}");
        }
    }
}