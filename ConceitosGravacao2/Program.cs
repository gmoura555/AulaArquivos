using System.Security.Cryptography;

namespace ConceitosGravacao2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\saida2.txt";
                string[] linhas = { "Curso 1: C#", "Curso 2: Asp.NET CORE", "Curso 3 PHP" };
                File.WriteAllLines(path, linhas);
                Console.WriteLine("Arquivo Criado");

                string path2 = @"c:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\saida3.txt";
                byte[] bytes = {  73, 109, 112, 97, 99, 116, 97, 32, 84,
 101, 99, 110, 111, 108, 111, 103, 105, 97 };
                File.WriteAllBytes(path2, bytes);
                Console.WriteLine("Arquivo Criado");
            }
            catch (Exception)
            {

            }


            Console.WriteLine("arquivo não Criado!! ");
        }
    }
}
