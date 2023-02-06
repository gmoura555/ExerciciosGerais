namespace Ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n1;
            Console.Write("Digite o valor de N1: ");
            n1 = decimal.Parse(Console.ReadLine());
            
            decimal n2;
            Console.Write("Digite o valor de N2: ");
            n2 = decimal.Parse(Console.ReadLine());


            decimal n3;
            Console.Write("Digite o valor de N3: ");
            n3 = decimal.Parse(Console.ReadLine());

            decimal mediaFinal = (n1 * 2 + (n2 * 3 + (n3 * 5))) / 10;

            Console.Write($"A média final é: {mediaFinal}");
            Console.ReadLine();
        }
    }
}