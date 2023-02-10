namespace ConceitosGravacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"C:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\saida1.txt";
                string conteudo = "Conteudo: Gravando dados com WriteAllText";
                File.WriteAllText(path, conteudo);
                Console.WriteLine("Arquivo criado com sucesso!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Algo deu errado - Arquivo nao criado");
            
            }
        }
    }
}