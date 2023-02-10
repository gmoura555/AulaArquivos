using System.IO;
using System.Runtime.CompilerServices;

namespace ConceitoGravacao5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Manipulação de Arquivos");
            Console.WriteLine(new String('-', 80));
            int opcao = 0;
            string local = @"c:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\ ";

            while (opcao != 5)
            {
                Console.WriteLine("1 - Criar Pasta");
                Console.WriteLine("2 - Criar Arquivo");
                Console.WriteLine("3 - Acrescentar Conteúdo no Arquivo");
                Console.WriteLine("4 - Ver Conteúdo do Arquivo");
                Console.WriteLine("5 - Sair");
                Console.WriteLine(new String('-', 80));

                Console.Write("Escolha sua opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(new String('-', 80));

                if (opcao == 1)
                {
                    Console.Write("Digite o nome da pasta: ");
                    string pasta = Console.ReadLine();
                    string path = local + pasta;
                    Directory.CreateDirectory(path);
                    Console.WriteLine(new String('-', 80));
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o nome da pasta a ser utilizada: ");
                    string pasta = Console.ReadLine();
                    Console.Write("Digite o nome do arquivo (com a extensão): ");
                    string arquivo = Console.ReadLine();
                    string path = local + pasta + @"\" + arquivo;

                    File.WriteAllText(path, "");
                    Console.WriteLine($"Arquivo: '{arquivo}' criado");
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o nome da pasta a ser utilizada: ");
                    string pasta = Console.ReadLine();
                    Console.Write("Digite o nome do arquivo (com a extensão): ");
                    string arquivo = Console.ReadLine();
                    string path = local + pasta + @"\" + arquivo;
                    if (!(File.Exists(path)))
                    {
                        Console.WriteLine("O arquivo solicitado não existe, verifique se as informações foram digitadas corretamente.");
                    }
                    else
                    {
                        Console.WriteLine("Digite o conteúdo a ser inserido no arquivo:");
                        Console.Write("-> ");
                        string conteudo = Console.ReadLine();
                        File.AppendAllText(path, conteudo);
                        Console.WriteLine(new String('-', 80));
                        Console.WriteLine($"Conteúdo inserido com sucesso no arquivo '{arquivo}'");
                    }
                    Console.WriteLine(new String('-', 80));
                }
                else if (opcao == 4)
                {
                    Console.Write("Digite o nome da pasta a ser utilizada: ");
                    string pasta = Console.ReadLine();
                    Console.Write("Digite o nome do arquivo (com a extensão): ");
                    string arquivo = Console.ReadLine();
                    string path = local + pasta + @"\" + arquivo;
                    if (!(File.Exists(path)))
                    {
                        Console.WriteLine("O arquivo solicitado não existe, verifique se as informações foram digitadas corretamente.");
                    }
                    else
                    {
                        Console.WriteLine("Conteúdo do arquivo:");
                        string[] linhas = File.ReadAllLines(path);
                        foreach (string linha in linhas)
                        {
                            Console.WriteLine(linha);
                        }
                    }
                    Console.WriteLine(new String('-', 80));
                }
                else if (opcao == 5)
                {
                    opcao = 5;
                }
            }

        }
    }
}