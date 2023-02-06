namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal base1;
            decimal altura;
            Console.Write("Digite a Base: ");
            base1 = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a Altura: ");
            altura = decimal.Parse(Console.ReadLine());
            decimal total = base1 * altura;
            Console.WriteLine($"Área total do Retângulo: {total}");
        }
    }
}