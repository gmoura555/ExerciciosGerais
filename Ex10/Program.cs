namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal cFabrica;
            Console.Write("Digite o custo de fabrica do veiculo: ");
            cFabrica =  Convert.ToInt32(Console.ReadLine());

            decimal vDistribuidor = ((cFabrica /100) * 28);
            decimal vTotaldis = vDistribuidor;
            decimal imposto = ((cFabrica  /100) * 45);
            decimal vimposto = imposto;
            decimal custoFinal = cFabrica + vTotaldis + vimposto;

            Console.WriteLine($"O valor total do veiculo para o consumidor final é: {custoFinal}");
            Console.ReadKey(); 

        }
    }
}