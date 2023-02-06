namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("CONVERSOR FAHRENHEIT / CELSIUS");
            Console.WriteLine(new string('-', 50));

            int gF;
            Console.Write("Digite um valor em Fahrenheit para a conversão: ");
            gF = Convert.ToInt32(Console.ReadLine());

            int resultado = ((gF - 32) / 9) * 5;

            Console.WriteLine($"{gF}° Fahrenheit corresponde a {resultado}° Celsius ");
            Console.ReadLine();


        }
    }
}