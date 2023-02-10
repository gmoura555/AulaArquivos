namespace ConceitosGravacao4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\saida2.txt";
            string[] inserir = { "C" };

            if (File.Exists(path))
            {
                File.AppendAllLines(path, inserir);
                Console.WriteLine("Arquivo Criado");
            }
            else 
            {
                File.WriteAllLines(path, inserir);
                Console.WriteLine("Arquivo Criado");
            }

           
        }
    }
}