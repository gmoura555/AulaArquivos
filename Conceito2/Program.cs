using System.IO;
namespace Conceito2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\conteudo.txt";
            string[] linhas = File.ReadAllLines(path);
            Console.WriteLine(linhas[3]);

            foreach (string linha in linhas) {
                Console.WriteLine(linha[3]);
            }
        }
    }
}