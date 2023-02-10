using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Conceito3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\guilherme.SIMSEG01\Meu Drive\CURSO C#\ArquivosTextos\conteudo.txt";
            byte[] bytes = File.ReadAllBytes(path);

            for (int i = 0; i < bytes.Length; i++)
            {
                Console.Write(bytes[i] + " ");

                if (i > 0 && i % 20 == 00)
                {
                    Console.WriteLine();
                }
            }
        }

        }
    }
