namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal salario;

            Console.Write("Digite o salário: ");
            salario = decimal.Parse(Console.ReadLine());


            decimal aumento;
            Console.Write("Digite o Reajuste: ");
            aumento = decimal.Parse(Console.ReadLine());

            decimal resultado = salario + ((aumento / 100) * salario);
            Console.WriteLine("Valor com aumento: " + resultado);


        }
    }
}