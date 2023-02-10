using System.IO;
namespace Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Metodos do System.IO
            //ReadAllText
            //ReadAllLines
            //ReadAllBytes
            try
            {
                string path = @"C:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\conteudo.txt";
                string texto = File.ReadAllText(path);

                Console.WriteLine(texto);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ops algo deu errado!\n Acione o TI");
               
            }
            
        }
    }
}