namespace Ex25
    
{
    internal class Program
    {
        


       public  static void Main(string[] args, float debito)
        {
            int nConta;
            float saldo;
            //float debito;
            float credito;
            float sAtual;
            string resp;
            float vsaque;
            
          

            Console.Write("Digite o numero da Conta Corrente: ");
            nConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o saldo: ");
            saldo = float.Parse(Console.ReadLine());

            
            Console.Write("Deseja efetuar um saque? S = Sim, N = Não");
            resp = Console.ReadLine();


            if (resp == "s")

            {
                Console.Write("Digite o valor do saque ou compra: ");
                debito = float.Parse(Console.ReadLine());

            }
            else
            {

            }


            //Console.Write("Digite o valor do saque ou compra: ");
            //debito = float.Parse(Console.ReadLine());


            Console.Write("Digite o valor do deposito: ");
            credito = float.Parse(Console.ReadLine());

            sAtual = saldo - debito + credito;

            if (sAtual >= 0)
            {
                Console.Write($"Saldo Positivo: {sAtual:c}");
            }
            else
            {
                Console.Write($"Saldo Negativo:{sAtual:c}");

            }
            Console.ReadKey();








        }
    }
}