namespace Ex24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sFixo;
            Console.Write("Digite o valor do sálario fixo: ");
            sFixo = Convert.ToInt32(Console.ReadLine());

             int vEfetuadas;
            Console.Write("Digite o valor total das vendas efetuadas:  ");
            vEfetuadas = Convert.ToInt32(Console.ReadLine());

            int comissao;
            int sTotal;
            
            
             
            if ( vEfetuadas < 1500)
            {
                comissao = vEfetuadas / 100 * 3;
            }

            else 
            { 
                comissao = vEfetuadas / 100 * 5;
            }

            sTotal = sFixo + comissao;  

        Console.WriteLine($"O valor da comissão é: {comissao}");
        Console.WriteLine($"Salário total é: {sTotal}" );
        }
    }
}