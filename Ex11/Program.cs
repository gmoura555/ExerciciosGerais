using System.Security.Cryptography.X509Certificates;

namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do vendedor: ");
            string vendedor = Console.ReadLine();   
                

            int cVendidos; //2 
            Console.Write("Digite o total de carros vendidos: ");
            cVendidos = Convert.ToInt32(Console.ReadLine());

            int tVendas; //20000
            Console.Write("Digite o valor total de vendas:  ");
            tVendas = Convert.ToInt32(Console.ReadLine());

            int sFixo;
            Console.Write("Digite o valor do salário:  "); //1.000
            sFixo = Convert.ToInt32(Console.ReadLine());

            int vVeiculo;
            vVeiculo = tVendas / cVendidos; //10000

            int cFixa;
            cFixa = ((vVeiculo /100)*3 * cVendidos );//600 comissao por veiculo


           int cValorVendas = ((tVendas /100)*5); //1000 comissao total vendas
            int sFinal = sFixo + cFixa + cValorVendas;
            Console.WriteLine(new string('-', 50));

            Console.WriteLine($"O salario final do {vendedor} é: {sFinal:c}");

                }
    }
}