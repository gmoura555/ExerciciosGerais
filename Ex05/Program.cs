namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int antecessor;
            Console.Write("Digite o número: ");
            numero = int.Parse(Console.ReadLine());
            antecessor = numero - 1;

            Console.WriteLine($"O atencessor de {numero} é {antecessor}");
        }
    }
}