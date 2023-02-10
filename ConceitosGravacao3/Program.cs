namespace ConceitosGravacao3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"c:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\saida2.txt";
                string[] inserir = { "Curso 4: HTML", "Curso 5: Ux Design", "Curso 6: Laravel" };
              
                File.AppendAllLines(path, inserir);
                Console.WriteLine("Arquivo Criado");


            }
            catch (Exception)
            {


                Console.WriteLine("arquivo não Criado!! ");
            }
        }
        }
    }
