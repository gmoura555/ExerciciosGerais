namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tEleitores = 1000;
            int vBrancos = 100;
            int vNulos = 100;
            int vValidos = tEleitores - (vBrancos + vNulos);


            Console.Write($"Total de Eleitores: {tEleitores}");
            Console.Write($"Total de votos em branco(%): {tEleitores /vBrancos}%");
            Console.Write($"Total de votos em Nulos(%): {tEleitores /vNulos}%");
            Console.Write($"Total de votos em válidos(%): {tEleitores /vNulos}%");
            Console.Write($"Total de votos em válidos(%): {(vValidos *100)/tEleitores}%");


        }
    }
}